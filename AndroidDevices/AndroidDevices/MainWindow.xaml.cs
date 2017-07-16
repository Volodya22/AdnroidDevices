using System.Windows;
using AndroidDevices.ViewModels;

namespace AndroidDevices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainContent.Content = new MainContentControl();
        }
    }
}
