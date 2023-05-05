namespace Biscuits.Devices
{
    using System;
    using AlgorithmConfiguration;

    public partial class Mct8329A
    {
        public Mct8329AIsdConfig ReadIsdConfig()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x80/*ISD_CONFIG*/);
            return (Mct8329AIsdConfig)value;
        }

        public Mct8329AMotorStartup1 ReadMotorStartup1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x82/*MOTOR_STARTUP1*/);
            return (Mct8329AMotorStartup1)value;
        }

        public Mct8329AMotorStartup2 ReadMotorStartup2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x84/*MOTOR_STARTUP2*/);
            return (Mct8329AMotorStartup2)value;
        }
    }
}
