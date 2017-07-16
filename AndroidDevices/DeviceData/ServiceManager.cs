using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceData;
using Managed.Adb;

namespace DeviceData
{
    public class ServiceManager
    {
        private static ServiceManager _instance;

        public static ServiceManager Instance
        {
            get { return _instance ?? (_instance = new ServiceManager()); }
        }

        public IDeviceManager GetDeviceManager()
        {
            return new DeviceManager();
        }
    }
}
