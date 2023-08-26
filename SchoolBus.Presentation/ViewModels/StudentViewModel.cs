using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using SchoolBus.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
    internal class StudentViewModel : ViewModelBase
    {
        readonly IRepository<Student> studentRepo = new Repository<Student>();
     
        readonly IRepository<Parent> parentRepo = new Repository<Parent>();
        
        readonly IRepository<Class> classRepo = new Repository<Class>();


        Student? selectedStudent = new();

        public Student? SelectedStudent
        {
            get { return selectedStudent; }
            set { Set(ref selectedStudent, value); }
        }


        public static ObservableCollection<Student>? students = new();

        public ObservableCollection<Student>? Students
        {
            get { return students; }
            set { Set(ref students, value); }
        }


        public void  GetStudentsWithParentAndClass()
        {
            List<Student> studentList = studentRepo.GetAll()!.ToList();

            Students = new();
            foreach (var student in studentList)
            {
                student.Parent = parentRepo.Get(student.ParentId);
                student.Class = classRepo.Get(student.ClassId);
                Students!.Add(student);
            }
        }

        public StudentViewModel(IRepository<Student> studentRepo)
        {
            this.studentRepo = studentRepo;
            Students = new ObservableCollection<Student>(this.studentRepo.GetAll()!);

            GetStudentsWithParentAndClass();
        }

        public static StudentAddView? window;

        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                window = new();
                window.Show();
                window.DataContext = new StudentAddViewModel();
            });
        }

        public RelayCommand Delete_Button
        {
            get => new(() =>
            {
                try
                {
                    studentRepo.Remove(SelectedStudent!);

                    Students!.Remove(SelectedStudent!);

                    studentRepo.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}