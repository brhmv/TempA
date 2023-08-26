using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
    internal class CarAddViewModel : ViewModelBase
    {
        readonly IRepository<Car>? carRepo = new Repository<Car>();

        public Car? _NewCar = new();

        public Car? NewCar
        {
            get { return _NewCar; }
            set { Set(ref _NewCar, value); }
        }


        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                try
                {
                    CarViewModel.Cars!.Add(NewCar!);
                    carRepo!.Add(NewCar!);
                    carRepo.SaveChanges();

                    CarViewModel.window!.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}