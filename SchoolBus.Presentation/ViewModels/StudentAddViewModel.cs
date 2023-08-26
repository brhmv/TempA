using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
    internal class StudentAddViewModel : ViewModelBase
    {
        readonly IRepository<Student>? studentRepo = new Repository<Student>();

        readonly IRepository<Class>? classRepo = new Repository<Class>();

        readonly IRepository<Parent>? parentRepo = new Repository<Parent>();



        ObservableCollection<Class>? classes = new();

        public ObservableCollection<Class>? Classes
        {
            get { return classes; }
            set { Set(ref classes, value); }
        }


        ObservableCollection<Parent>? parents = new();

        public ObservableCollection<Parent>? Parents
        {
            get { return parents; }
            set { Set(ref parents, value); }
        }


        public Student? newStudent = new();

        public Student? NewStudent
        {
            get { return newStudent; }
            set { Set(ref newStudent, value); }
        }

        Class? selectedClass;

        public Class? SelectedClass
        {
            get { return selectedClass; }
            set { Set(ref selectedClass, value); }
        }

        Parent? selectedParent;

        public Parent? SelectedParent
        {
            get { return selectedParent; }
            set { Set(ref selectedParent, value); }
        }


        public StudentAddViewModel()
        {
            Classes = new ObservableCollection<Class>(classRepo.GetAll()!);
            Parents = new ObservableCollection<Parent>(parentRepo.GetAll()!);
        }

        void GetStudentsWithParentAndClass()
        {
            List<Student> studentList = studentRepo.GetAll()!.ToList();

            StudentViewModel.students = new();
            foreach (var student in studentList)
            {
                student.Parent = parentRepo!.Get(student.ParentId);
                student.Class = classRepo!.Get(student.ClassId);
                StudentViewModel.students!.Add(student);
            }

        }

        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                try
                {
                    if (SelectedClass != null && selectedParent != null && NewStudent!.FirstName != null && NewStudent.LastName != null && newStudent!.Address != null )
                    {
                        NewStudent!.ParentId = SelectedParent!.Id;
                        NewStudent.ClassId = SelectedClass.Id;

                        StudentViewModel.students!.Add(NewStudent!);
                        studentRepo!.Add(NewStudent!);
                        studentRepo.SaveChanges();

                        GetStudentsWithParentAndClass();


                        StudentViewModel.window!.Close();                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}