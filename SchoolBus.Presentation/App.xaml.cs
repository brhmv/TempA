using GalaSoft.MvvmLight.Messaging;
using SchoolBus.Data.Repos;
using SchoolBus.Models.Concretes;
using SchoolBus.Presentation.Services;
using SchoolBus.Presentation.ViewModels;
using SchoolBus.Presentation.Views;
using SimpleInjector;
using System.Windows;

namespace SchoolBus.Presentation
{
    public partial class App : Application
    {
        public static Container? Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            Window window = new MainWindow();
            var viewModel = Container!.GetInstance<MainViewModel>();
            window.DataContext = viewModel;

            window.ShowDialog();

            base.OnStartup(e);
        }

        private void Register()
        {
            Container = new Container();

            Container.RegisterSingleton<INavigationService, NavigationService>();
           
            Container.RegisterSingleton<IMessenger, Messenger>();


            Container.RegisterSingleton<MainViewModel>();

            Container.RegisterSingleton<CarViewModel>();

            Container.RegisterSingleton<DriverViewModel>();

            Container.RegisterSingleton<ParentViewModel>();

            Container.RegisterSingleton<CreateRideViewModel>();

            Container.RegisterSingleton<ClassViewModel>();

            Container.RegisterSingleton<StudentViewModel>();

            Container.RegisterSingleton<RideViewModel>();

            //Container.RegisterSingleton<CarAddViewModel>();

            //add models



            Container.RegisterSingleton<IRepository<Car>, Repository<Car>>();

            Container.RegisterSingleton<IRepository<Driver>, Repository<Driver>>();

            Container.RegisterSingleton<IRepository<Class>, Repository<Class>>();

            Container.RegisterSingleton<IRepository<Parent>, Repository<Parent>>();

            Container.RegisterSingleton<IRepository<Student>, Repository<Student>>();

            Container.RegisterSingleton<IRepository<Ride>, Repository<Ride>>();



            
        }
    }
}