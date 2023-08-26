using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using System;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
    internal class ClassAddViewModel : ViewModelBase
    {
        readonly IRepository<Class>? classRepo = new Repository<Class>();


        Class? newClass = new();

        public Class? NewClass
        {
            get { return newClass; }
            set { Set(ref newClass, value); }
        }


        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                try
                {
                    ClassViewModel.Classes!.Add(NewClass!);

                    classRepo!.Add(NewClass!);

                    classRepo.SaveChanges();

                    ClassViewModel.window!.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}