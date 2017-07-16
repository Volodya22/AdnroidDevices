using System.Collections.Generic;
using Managed.Adb;

namespace DeviceData
{
    public interface IDeviceManager
    {
        List<Device> GetDevices(string pathToAdb);
    }
}
