using GalaSoft.MvvmLight;

namespace SchoolBus.Presentation.Services
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : ViewModelBase;
    }
}