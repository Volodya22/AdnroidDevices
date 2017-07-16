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

        private NavigationManager(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public static NavigationManager Instanse
        {
            get
            {
                return _instanse;
            }
        }

        public static void CreateNavigationManager(NavigationService mainFrameService)
        {
            _instanse = new NavigationManager(mainFrameService);
        }

        private object GetNavigateObject(object obj)
        {
            if (obj is DevicesListViewModel)
            {
                return new DevicesListView { DataContext = obj };
            }
            if (obj is DeviceViewModel)
            {
                return new DeviceStatsView { DataContext = obj };
            }
            else
            {
                throw new ArgumentException("Incorrect navigation parameter!");
            }
        }

        public void Navigate(object target)
        {
            var navigatedObject = GetNavigateObject(target);

            _navigationService.Navigate(navigatedObject);
        }
    }
}
