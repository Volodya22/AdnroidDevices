using System;
using System.Windows.Navigation;
using AndroidDevices.ViewModels;
using AndroidDevices.Views;

namespace AndroidDevices.Navigation
{
    public class NavigationManager
    {
        private readonly NavigationService _navigationService;
        private static NavigationManager _instanse;
        private readonly DevicesListView _listView;

        private NavigationManager(NavigationService navigationService, DevicesListView listView)
        {
            _navigationService = navigationService;

            _listView = listView;
        }

        public static NavigationManager Instanse
        {
            get
            {
                return _instanse;
            }
        }

        public static void CreateNavigationManager(NavigationService mainFrameService, DevicesListView listView)
        {
            _instanse = new NavigationManager(mainFrameService, listView);
        }

        private object GetNavigateObject(object obj)
        {
            if (obj is DevicesListViewModel)
            {
                return new DevicesListView { DataContext = obj };
            }
            if (obj is DeviceStatsViewModel)
            {
                return new DeviceStatsView { DataContext = obj };
            }
            else
            {
                throw new ArgumentException("Некорректный параметр навигации");
            }
        }

        public void Navigate(object target)
        {
            var navigatedObject = GetNavigateObject(target);

            _navigationService.Navigate(navigatedObject);
        }

        public void NavigateToList()
        {
            _navigationService.Navigate(_listView);
        }
    }
}
