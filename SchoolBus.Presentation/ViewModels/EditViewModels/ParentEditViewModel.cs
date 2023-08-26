using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels.EditViewModels
{
    class ParentEditViewModel : ViewModelBase
    {
        readonly IRepository<Parent>? parentRepo = new Repository<Parent>();

        public Parent? newParent = new();

        public Parent? NewParent
        {
            get { return newParent; }
            set { Set(ref newParent, value); }
        }


        public ParentEditViewModel()
        {
            NewParent = ParentViewModel.selectedParent!;
        }

        public RelayCommand Update_Button
        {
            get => new(() =>
            {
                try
                {
                    var temp = ParentViewModel.selectedParent;

                    Parent editedParent = parentRepo!.Get(c => c.Id == ParentViewModel.selectedParent!.Id!)!.FirstOrDefault()!;

                    editedParent.FirstName = NewParent!.FirstName;
                    editedParent.LastName = NewParent.LastName;
                    editedParent.PhoneNumber = NewParent.PhoneNumber;

                    parentRepo.Update(editedParent);
                    parentRepo.SaveChanges();

                    ParentViewModel.Parents!.Remove(temp!);
                    ParentViewModel.Parents.Add(editedParent);

                    ParentViewModel.editWindow!.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}