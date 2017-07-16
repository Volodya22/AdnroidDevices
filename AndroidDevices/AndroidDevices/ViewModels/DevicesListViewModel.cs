using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using DeviceData;
using Managed.Adb;

namespace AndroidDevices.ViewModels
{
    public class DevicesListViewModel : BaseViewModel
    {
        private readonly IDeviceManager _deviceManager;

        public DevicesListViewModel()
        {
            Devices = new ObservableCollection<DeviceViewModel>();
            _deviceManager = ServiceManager.Instance.GetDeviceManager();

            GetDevices();
        }

        public ObservableCollection<DeviceViewModel> Devices { get; set; }

        public void GetDevices()
        {
            Devices.Clear();

            var devices = _deviceManager.GetDevices(ConfigurationManager.AppSettings["AdbPath"]);

            if (devices.Count == 0)
            {
                while (Devices.Count < 3)
                {
                    Devices.Add(GetDeviceTemplate());
                }
            }
            else
            {
                foreach (var device in devices)
                {
                    Devices.Add(new DeviceViewModel(device));
                }
            }
        }

        private DeviceViewModel GetDeviceTemplate()
        {
            return new DeviceViewModel();
        }
    }
}
