using System.Collections.ObjectModel;
using AndroidDevices.Models;

namespace AndroidDevices.ViewModels
{
    public class DevicesListViewModel : BaseViewModel
    {
        public DevicesListViewModel()
        {
            Devices = new ObservableCollection<DeviceViewModel>();

            GetDevices();
        }

        public ObservableCollection<DeviceViewModel> Devices { get; set; }

        public void GetDevices()
        {
            Devices.Clear();

            while (Devices.Count < 3)
            {
                Devices.Add(GetDeviceTemplate());
            }
        }

        private DeviceViewModel GetDeviceTemplate()
        {
            return new DeviceViewModel(new Device
            {
                SerialNumber = "123",
                DeviceType = "Emulator"
            });
        }
    }
}
