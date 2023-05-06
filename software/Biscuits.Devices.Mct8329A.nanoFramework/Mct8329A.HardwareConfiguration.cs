namespace Biscuits.Devices
{
    using System;
    using HardwareConfiguration;

    public partial class Mct8329A
    {
        public Mct8329APinConfig1 ReadPinConfig1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xA6/*PIN_CONFIG1*/);
            return (Mct8329APinConfig1)value;
        }

        public Mct8329APinConfig2 ReadPinConfig2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xA8/*PIN_CONFIG2*/);
            return (Mct8329APinConfig2)value;
        }

        public Mct8329ADeviceConfig ReadDeviceConfig()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xAA/*DEVICE_CONFIG*/);
            return (Mct8329ADeviceConfig)value;
        }
    }
}
