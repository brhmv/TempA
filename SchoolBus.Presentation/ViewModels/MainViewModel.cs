using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SchoolBus.Presentation.Messages;
using SchoolBus.Presentation.Services;

namespace SchoolBus.Presentation.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        INavigationService navigationService;


        ViewModelBase? currentViewModel;

        public ViewModelBase? CurrentViewModel
        {
            get => currentViewModel;
            set => Set(ref currentViewModel, value);
        }


        public MainViewModel(IMessenger messenger, INavigationService navigation)
        {
            navigationService = navigation;
            messenger.Register<NavigationMessage>(this,
                message =>
                {
                    var viewModel = App.Container!.GetInstance(message.ViewModelType!) as ViewModelBase;
                    CurrentViewModel = viewModel;
                });

            navigationService.NavigateTo<CreateRideViewModel>();
        }


        public RelayCommand CreateRideCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<CreateRideViewModel>();
            });
        }

        public RelayCommand RideCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<RideViewModel>();
            });
        }

        public RelayCommand ClassCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<ClassViewModel>();
            });
        }

        public RelayCommand StudentCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<StudentViewModel>();
            });
        }

        public RelayCommand ParentCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<ParentViewModel>();
            });
        }

        public RelayCommand DriverCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<DriverViewModel>();
            });
        }

        public RelayCommand CarCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<CarViewModel>();
            });
        }

    }
}