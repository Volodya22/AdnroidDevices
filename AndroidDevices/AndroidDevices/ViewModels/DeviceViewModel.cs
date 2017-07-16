using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Managed.Adb;

namespace AndroidDevices.ViewModels
{
    public class DeviceViewModel
    {
        public DeviceViewModel()
        {
            var rnd = new Random();

            SerialNumber = "SerialNumber";
            DeviceType = rnd.Next(2) == 0 ? "Emulator" : "Device";
            Model = "Model";
            Manufacturer = "Manufacturer";
            OSVersion = "OSVersion";
            AvailableSpace = rnd.Next(100) + "Mb";
            BatteryValue = new ObservableCollection<KeyValuePair<string, int>>(new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Battery Level", rnd.Next(100))
            });

            StorageInfo = new ObservableCollection<KeyValuePair<string, int>>(new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Media", rnd.Next(50)),
                new KeyValuePair<string, int>("Apps", rnd.Next(50)),
                new KeyValuePair<string, int>("Free", rnd.Next(50))
            });
        }

        public DeviceViewModel(Device model)
        {
            SerialNumber = model.SerialNumber;
            DeviceType = model.IsEmulator ? "Emulator" : "Device";
            Model = model.Model;

            if (model.Properties.Count > 0)
            {
                Manufacturer = model.Properties["ro.product.manufacturer"];
                OSVersion = model.Properties["ro.build.version.release"];

                if (Model == "") Model = model.Properties["ro.product.model"];
            }
            
            AvailableSpace = "100 Mb";
            BatteryValue = new ObservableCollection<KeyValuePair<string, int>>(new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Battery Level", model.GetBatteryInfo().Level)
            });
        }

        public string SerialNumber { get; }

        public string DeviceType { get; }

        public string Model { get; }

        public string Manufacturer { get; }

        public string OSVersion { get; }

        public string AvailableSpace { get; }

        public ObservableCollection<KeyValuePair<string, int>> BatteryValue { get; }

        public ObservableCollection<KeyValuePair<string, int>> StorageInfo { get; }
    }
}
