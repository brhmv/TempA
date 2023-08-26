using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using SchoolBus.Presentation.Messages;

namespace SchoolBus.Presentation.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IMessenger messenger;

        public NavigationService(IMessenger messenger)
        {
            this.messenger = messenger;
        }

        public void NavigateTo<T>() where T : ViewModelBase
        {
            messenger.Send(new NavigationMessage { ViewModelType = typeof(T) });
        }
    }
}