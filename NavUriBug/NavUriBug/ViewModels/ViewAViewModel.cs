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
            UpdateCommand = new DelegateCommand(OnUpdateCommandExecuted);
        }

        public DelegateCommand UpdateCommand { get; }

        private void OnUpdateCommandExecuted()
        {
            NavPath2 = NavigationService.GetNavigationUriPath();
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _navPath1;
        public string NavPath1
        {
            get { return _navPath1; }
            set { SetProperty(ref _navPath1, value); }
        }

        private string _navPath2;
        public string NavPath2
        {
            get { return _navPath2; }
            set { SetProperty(ref _navPath2, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
            NavPath1 = NavigationService.GetNavigationUriPath();
        }
    }
}
