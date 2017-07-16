using System.Windows;
using System.Windows.Controls;
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
    }
}
