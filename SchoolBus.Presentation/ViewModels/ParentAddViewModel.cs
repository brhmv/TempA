using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using System;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
    internal class ParentAddViewModel : ViewModelBase
    {
        readonly IRepository<Parent>? parentRepo = new Repository<Parent>();


        Parent? newParent = new();

        public Parent? NewParent
        {
            get { return newParent; }
            set { Set(ref newParent, value); }
        }


        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                try
                {
                    ParentViewModel.Parents!.Add(NewParent!);

                    parentRepo!.Add(NewParent!);

                    parentRepo.SaveChanges();


                    ParentViewModel.window!.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}