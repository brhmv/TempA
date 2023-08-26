using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using SchoolBus.Presentation.ViewModels.EditViewModels;
using SchoolBus.Presentation.Views;
using SchoolBus.Presentation.Views.EditViews;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
    internal class DriverViewModel : ViewModelBase
    {
        readonly IRepository<Driver> driverRepo;

        readonly IRepository<Car> carRepo =new Repository<Car>();


        public static ObservableCollection<Driver>? Drivers { get; set; }


        public static Driver? selectedDriver = new();

        public Driver? SelectedDriver
        {
            get { return selectedDriver; }
            set { Set(ref selectedDriver, value); }
        }


        public DriverViewModel(IRepository<Driver> driverRepo)
        {
            this.driverRepo = driverRepo;
            Drivers = new ObservableCollection<Driver>(this.driverRepo.GetAll()!);
        }

        public static DriverAddView? window;       
        
        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                window = new();
                window.Show();
                window.DataContext = new DriverAddViewModel();
            });
        }

        public RelayCommand Delete_Button
        {
            get => new(() =>
            {
                try
                {
                    var driver = driverRepo.Get(SelectedDriver!.Id);
                    if (driver != null)
                    {
                        var car = driver.Car;

                        if (car != null)
                        {
                            driver.Car = null; 
                            carRepo.Update(car); 
                        }

                        driverRepo.Remove(driver);
                        driverRepo.SaveChanges();
                        Drivers!.Remove(SelectedDriver!);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }


        public static DriverEditView? Editwindow;

        public RelayCommand Update_Button
        {
            get => new(() =>
            {
                Editwindow = new();
                Editwindow.Show();
                Editwindow.DataContext = new DriverEditViewModel();
            });
        }
    }
}