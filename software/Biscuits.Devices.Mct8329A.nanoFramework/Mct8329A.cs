namespace Biscuits.Devices
{
    using System;
    using System.Device.I2c;

    public partial class Mct8329A : IDisposable
    {
        private const int DefaultAddress = 0x60;

        private readonly int _busId;
        private readonly int _deviceAddress;

        private I2cDevice _device;
        private bool _disposed;

        public Mct8329A(int busId)
            : this(busId, DefaultAddress)
        {
        }

        public Mct8329A(int busId, int deviceAddress)
        {
            _busId = busId;
            _deviceAddress = deviceAddress;

            Initialize();
        }

        private void Initialize()
        {
            var settings = new I2cConnectionSettings(_busId, _deviceAddress, I2cBusSpeed.FastMode);
            _device = I2cDevice.Create(settings);
        }

        public Mct8329AGateDriverFaultStatus ReadGateDriverFaultStatus()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xE0/*GATE_DRIVER_FAULT_STATUS*/);
            return (Mct8329AGateDriverFaultStatus)value;
        }

        public Mct8329AControllerFaultStatus ReadControllerFaultStatus()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xE2/*CONTROLLER_FAULT_STATUS*/);
            return (Mct8329AControllerFaultStatus)value;
        }

        public Mct8329ASysStatus1 ReadSysStatus1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xE4/*SYS_STATUS1*/);
            return (Mct8329ASysStatus1)value;
        }

        public Mct8329ASysStatus2 ReadSysStatus2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xEA/*SYS_STATUS2*/);
            return (Mct8329ASysStatus2)value;
        }

        public Mct8329ASysStatus3 ReadSysStatus3()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xEC/*SYS_STATUS3*/);
            return (Mct8329ASysStatus3)value;
        }

        public Mct8329ADeviceCtrl ReadDeviceCtrl()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xE8/*DEVICE_CTRL*/);
            return (Mct8329ADeviceCtrl)value;
        }

        public float ReadInputDuty()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x40C/*INPUT_DUTY*/);
            return value / 1073741824f/*2^30*/;
        }

        public float ReadCurrentDuty()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x512/*CURRENT_DUTY*/);
            return value / 1073741824f/*2^30*/;
        }

        public float ReadSetDuty()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x522/*SET_DUTY*/);
            return value / 1073741824f/*2^30*/;
        }

        public float ReadMotorSpeedPU()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x5CE/*MOTOR_SPEED_PU*/);
            return value / 1073741824f/*2^30*/;
        }

        public float ReadDCBusPowerPU()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x714/*DC_BUS_POWER_PU*/);
            return value / 1073741824f/*2^30*/;
        }

        private uint ReadUInt32(ushort registerAddressOffset)
        {
            var buffer = new byte[4];

            _device.WriteRead(
                new[] {
                    (byte)(0b1 << 7/*OP_R/W = Read*/ | 0b0/*CRC_EN = False*/ | (0b01 << 5)/*DLEN = 32-bit*/ | 0x0/*M_SEC*/),
                    (byte)((0x0/*M_PAGE*/ << 4) | (((uint)registerAddressOffset >> 8) & 0xF)),
                    (byte)((uint)registerAddressOffset & 0xFF)
                },
                buffer);

            return BitConverter.ToUInt32(buffer, 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _device.Dispose();
            }

            _disposed = true;
        }
    }
}
