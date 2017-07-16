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
        public MainContentControl()
        {
            InitializeComponent();

            var listViewModel = new DevicesListViewModel();

            NavigationManager.CreateNavigationManager(NavigationService);
            NavigationManager.Instanse.Navigate(listViewModel);
        }
    }
}
