using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AndroidDevices.Navigation;
using AndroidDevices.ViewModels;

namespace AndroidDevices.Views
{
    /// <summary>
    /// Interaction logic for DevicesListView.xaml
    /// </summary>
    public partial class DevicesListView : Page
    {
        public DevicesListView()
        {
            InitializeComponent();

            DataContext = new DevicesListViewModel();
        }

        private DevicesListViewModel Model
        {
            get { return (DevicesListViewModel) DataContext; }
        }

        private void BtRefresh_OnClick(object sender, RoutedEventArgs e)
        {
            Model.GetDevices();
        }

        private void EventSetter_OnHandler(object sender, MouseButtonEventArgs e)
        {
            var row = sender as DataGridRow;

            var context = row?.DataContext as DeviceViewModel;

            if (context == null) return;

            NavigationManager.Instanse.Navigate(context);
        }

        private void BtExit_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
