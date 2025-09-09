using expences.core;
using System;
using System.Security.Cryptography.X509Certificates;

namespace expences.mvvm.viewmodel
{
    class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVM { get; set; }
        public UserViewModel UserVM { get; set; }
        public DashBoardViewModel DashboardVM { get; set; }
        public RecordViewModel RecordVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnProperlyCharged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            UserVM = new UserViewModel();
            DashboardVM = new DashBoardViewModel();
            RecordVM = new RecordViewModel();
            CurrentView = HomeVM;
        }
    }
}
