namespace AndroidDevices.Models
{
    public class Device
    {
        public string SerialNumber { get; set; }

        public string DeviceType { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string OSVersion { get; set; }

        public int ChargeLevel { get; set; }
    }
}
