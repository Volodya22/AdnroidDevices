using AndroidDevices.Models;

namespace AndroidDevices.ViewModels
{
    public class DeviceViewModel
    {
        private readonly Device _model;

        public DeviceViewModel(Device model)
        {
            _model = model;
        }

        public string SerialNumber
        {
            get { return _model.SerialNumber; }
        }

        public string DeviceType
        {
            get { return _model.DeviceType; }
        }

        public string NameToShow
        {
            get { return _model.SerialNumber + " (" + _model.DeviceType + ")"; }
        }
    }
}
