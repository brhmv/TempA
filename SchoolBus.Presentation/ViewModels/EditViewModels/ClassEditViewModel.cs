using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using System;
using System.Linq;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels.EditViewModels
{
    class ClassEditViewModel : ViewModelBase
    {
        readonly IRepository<Class>? classRepo = new Repository<Class>();

        public Class? newClass = new();

        public Class? NewClass
        {
            get { return newClass; }
            set { Set(ref newClass, value); }
        }


        public ClassEditViewModel()
        {
            NewClass = ClassViewModel.selectedClass!;
        }

        public RelayCommand Update_Button
        {
            get => new(() =>
            {
                try
                {
                    var temp = ClassViewModel.selectedClass;

                    Class editedClass = classRepo!.Get(c => c.Id == ClassViewModel.selectedClass!.Id!)!.FirstOrDefault()!;

                    editedClass.Name = NewClass!.Name;

                    classRepo.Update(editedClass);
                    classRepo.SaveChanges();

                    ClassViewModel.Classes!.Remove(temp!);
                    ClassViewModel.Classes.Add(editedClass);

                    ClassViewModel.EditWindow!.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}