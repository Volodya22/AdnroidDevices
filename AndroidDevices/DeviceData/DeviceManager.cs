using System.Collections.Generic;
using System.Linq;
using Managed.Adb;

namespace DeviceData
{
    internal class DeviceManager : IDeviceManager
    {
        public List<Device> GetDevices(string pathToAdb)
        {
            var madb = AndroidDebugBridge.CreateBridge(pathToAdb, true);
            madb.Start();

            var devices = AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress).ToList();

            madb.Stop();

            return devices;
        }
    }
}
