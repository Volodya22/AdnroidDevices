using AndroidDevices.Navigation;
using AndroidDevices.ViewModels;
using AndroidDevices.Views;

namespace AndroidDevices
{
    /// <summary>
    /// Interaction logic for MainContentControl.xaml
    /// </summary>
    public partial class MainContentControl
    {
        public MainContentControl(DevicesListViewModel list)
        {
            InitializeComponent();

            var listView = new DevicesListView { DataContext = list };

            NavigationManager.CreateNavigationManager(NavigationService, listView);
            NavigationManager.Instanse.NavigateToList();
        }
    }
}
