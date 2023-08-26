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
    class DriverEditViewModel : ViewModelBase
    {
        readonly IRepository<Driver>? driverRepo = new Repository<Driver>();

        public Driver? newDriver = new();

        public Driver? NewDriver
        {
            get { return newDriver; }
            set { Set(ref newDriver, value); }
        }


        public DriverEditViewModel()
        {
            NewDriver = DriverViewModel.selectedDriver!;
        }

        public RelayCommand Update_Button
        {
            get => new(() =>
            {
                try
                {
                    var temp = DriverViewModel.selectedDriver;

                    Driver editedDriver = driverRepo!.Get(c => c.Id == DriverViewModel.selectedDriver!.Id!)!.FirstOrDefault()!;

                    editedDriver.License = NewDriver!.License;
                    editedDriver.FirstName = NewDriver!.FirstName;
                    editedDriver.LastName = NewDriver.LastName;
                    editedDriver.Address = NewDriver.Address;
                    editedDriver.Phone = NewDriver.Phone;
                    editedDriver.Ride = NewDriver.Ride;
                    editedDriver.Car = NewDriver!.Car;
                    editedDriver.CarId = NewDriver!.CarId;


                    driverRepo.Update(editedDriver!);
                    driverRepo.SaveChanges();

                    DriverViewModel.Drivers!.Remove(temp!);
                    DriverViewModel.Drivers!.Add(editedDriver);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}