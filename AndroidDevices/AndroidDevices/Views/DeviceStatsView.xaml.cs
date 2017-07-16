using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using AndroidDevices.Navigation;
using AndroidDevices.ViewModels;

namespace AndroidDevices.Views
{
    /// <summary>
    /// Interaction logic for DeviceStatsView.xaml
    /// </summary>
    public partial class DeviceStatsView : Page
    {
        public DeviceStatsView()
        {
            InitializeComponent();
        }

        private void BtBack_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationManager.Instanse.Navigate(new DevicesListViewModel());
        }

        private void BtExit_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
