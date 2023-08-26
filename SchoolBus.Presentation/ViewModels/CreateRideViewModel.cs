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
using System.Windows.Input;

namespace SchoolBus.Presentation.ViewModels
{
    internal class CreateRideViewModel : ViewModelBase
    {
        #region Repos
        readonly IRepository<Driver>? driverRepo = new Repository<Driver>();

        readonly IRepository<Car>? carRepo = new Repository<Car>();

        readonly IRepository<Ride>? rideRepo = new Repository<Ride>();

        readonly IRepository<Parent> parentRepo = new Repository<Parent>();

        readonly IRepository<Class> classRepo = new Repository<Class>();

        readonly IRepository<Student>? studentRepo = new Repository<Student>();
        #endregion

        #region Ride

        Ride newRide = new();

        public Ride NewRide
        {
            get { return newRide; }
            set { Set(ref newRide, value); }
        }

        ObservableCollection<Driver>? drivers = new();

        public ObservableCollection<Driver>? Drivers
        {
            get { return drivers; }
            set { Set(ref drivers, value); }
        }


        Driver selectedDriver = new();

        public Driver SelectedDriver
        {
            get { return selectedDriver; }
            set { Set(ref selectedDriver, value); }
        }


        Car car = new();

        public Car CarOfSelectedDriver
        {
            get { return car; }
            set { Set(ref car, value); }
        }


        int countOfStudents = 0;

        public int CountOfStudents
        {
            get { return countOfStudents; }
            set { Set(ref countOfStudents, value); }
        }


        public RelayCommand DriverChangedCommand
        {
            get => new(() =>
            {
                CarOfSelectedDriver = SelectedDriver.Car!;
            });
        }

        public void GetDriversWithCars()
        {
            List<Driver> driverList = driverRepo!.GetAll()!.ToList();

            Drivers = new();
            foreach (var driver in driverList)
            {
                driver.Car = carRepo!.Get(driver.CarId);
                Drivers!.Add(driver);
            }
        }

        #endregion

        #region ListBox1

        ObservableCollection<Student>? students = new();

        public ObservableCollection<Student>? Students
        {
            get { return students; }
            set { Set(ref students, value); }
        }


        Student selectedStudent1;

        public Student SelectedStudent1
        {
            get { return selectedStudent1; }
            set { Set(ref selectedStudent1, value); }
        }


        public void GetStudentsWithParentAndClass()
        {
            List<Student> studentList = studentRepo!.GetAll()!.Where(st => st.RideId == null).ToList();

            Students = new();

            foreach (var student in studentList)
            {

                student.Parent = parentRepo.Get(student.ParentId);
                student.Class = classRepo.Get(student.ClassId);
                Students!.Add(student);
            }
        }

        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                try
                {
                    if (SelectedStudent1 != null)
                    {
                        var temp = SelectedStudent1;
                        Students!.Remove(temp);
                        StudentsToRemove!.Add(temp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        #endregion

        #region ListBox2

        ObservableCollection<Student>? studentsToRemove = new();

        public ObservableCollection<Student>? StudentsToRemove
        {
            get { return studentsToRemove; }
            set { Set(ref studentsToRemove, value); }
        }

        Student selectedStudent2;

        public Student SelectedStudent2;

        public RelayCommand Remove_Button
        {
            get => new(() =>
            {
                try
                {
                    if (SelectedStudent2 != null)
                    {
                        var temp = selectedStudent2; ;
                        Students!.Add(temp);
                        StudentsToRemove!.Remove(temp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        #endregion

        public CreateRideViewModel()
        {
            Drivers = new ObservableCollection<Driver>(driverRepo.GetAll()!);
            Students = new ObservableCollection<Student>(studentRepo.GetAll()!);
            GetDriversWithCars();
            GetStudentsWithParentAndClass();
        }

        public void GetStudentsWithCarAndDriver()
        {
            List<Ride> rideList = rideRepo!.GetAll()!.ToList();

            RideViewModel.rides = new();

            foreach (var ride in rideList)
            {
                ride.Driver = driverRepo!.Get(ride.DriverId!.Value);
                ride.Car = carRepo!.Get(ride.CarId);
                RideViewModel.rides!.Add(ride);
            }
        }

        public RelayCommand AddRide_Button
        {
            get => new(() =>
            {
                try
                {
                    if (SelectedDriver != null && Students != new ObservableCollection<Student>())
                    {
                        NewRide!.CarId = SelectedDriver!.CarId;
                        NewRide.DriverId = SelectedDriver.Id;

                        RideViewModel.rides!.Add(NewRide!);
                        rideRepo!.Add(NewRide!);
                        rideRepo.SaveChanges();

                        foreach (var student in StudentsToRemove!)
                            student.RideId = NewRide.Id;

                        studentRepo!.SaveChanges();

                        StudentsToRemove = new();

                        MessageBox.Show("Ride Created Succesfully!");

                        GetStudentsWithCarAndDriver();
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