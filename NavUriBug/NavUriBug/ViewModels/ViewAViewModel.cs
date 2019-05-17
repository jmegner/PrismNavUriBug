using System;
using Prism.Commands;
using Prism.Navigation;

namespace NavUriBug.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        public ViewAViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "View A";
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _navPath;
        public string NavPath
        {
            get { return _navPath; }
            set { SetProperty(ref _navPath, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
            NavPath = NavigationService.GetNavigationUriPath();
        }
    }
}
