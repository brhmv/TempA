using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels.EditViewModels
{
    class CarEditViewModel : ViewModelBase
    {
        readonly IRepository<Car>? carRepo = new Repository<Car>();

        public Car? _NewCar = new();

        public Car? NewCar
        {
            get { return _NewCar; }
            set { Set(ref _NewCar, value); }
        }


        public CarEditViewModel()
        {
            NewCar = CarViewModel._SelectedCar!;
        }

        public RelayCommand Update_Button
        {
            get => new(() =>
            {
                try
                {
                    var temp = CarViewModel._SelectedCar;                    

                    Car editedCar = carRepo!.Get(c => c.Id == CarViewModel._SelectedCar!.Id!)!.FirstOrDefault()!;

                    editedCar.Name = NewCar!.Name;
                    editedCar.Number = NewCar.Number;
                    editedCar.SeatCount = NewCar.SeatCount;

                    carRepo.Update(editedCar);
                    carRepo.SaveChanges();

                    CarViewModel.Cars!.Remove(temp!);
                    CarViewModel.Cars.Add(editedCar);

                    CarViewModel.editWindow!.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

    }
}