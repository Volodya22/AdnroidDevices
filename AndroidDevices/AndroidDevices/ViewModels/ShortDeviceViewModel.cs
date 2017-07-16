using Managed.Adb;

namespace AndroidDevices.ViewModels
{
    public class ShortDeviceViewModel
    {
        private readonly Device _model;

        public ShortDeviceViewModel(Device model)
        {
            _model = model;
        }

        public string SerialNumber
        {
            get { return _model.SerialNumber; }
        }

        public string DeviceType
        {
            get { return _model.IsEmulator ? "Emulator" : "Device"; }
        }
    }
}
