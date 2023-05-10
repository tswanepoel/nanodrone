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

        public void WriteIsdConfig(Mct8329AIsdConfig isdConfig)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x80/*ISD_CONFIG*/, (uint)isdConfig);
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

        public void WriteMotorStartup1(Mct8329AMotorStartup1 motorStartup1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x82/*MOTOR_STARTUP1*/, (uint)motorStartup1);
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

        public void WriteMotorStartup2(Mct8329AMotorStartup2 motorStartup2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x84/*MOTOR_STARTUP2*/, (uint)motorStartup2);
        }

        public Mct8329AClosedLoop1 ReadClosedLoop1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x86/*CLOSED_LOOP1*/);
            return (Mct8329AClosedLoop1)value;
        }

        public void WriteClosedLoop1(Mct8329AClosedLoop1 closedLoop1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x86/*CLOSED_LOOP1*/, (uint)closedLoop1);
        }

        public Mct8329AClosedLoop2 ReadClosedLoop2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x88/*CLOSED_LOOP2*/);
            return (Mct8329AClosedLoop2)value;
        }

        public void WriteClosedLoop2(Mct8329AClosedLoop2 closedLoop2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x88/*CLOSED_LOOP2*/, (uint)closedLoop2);
        }

        public Mct8329AClosedLoop3 ReadClosedLoop3()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x8A/*CLOSED_LOOP3*/);
            return (Mct8329AClosedLoop3)value;
        }

        public void WriteClosedLoop3(Mct8329AClosedLoop3 closedLoop3)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x8A/*CLOSED_LOOP3*/, (uint)closedLoop3);
        }

        public Mct8329AClosedLoop4 ReadClosedLoop4()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x8C/*CLOSED_LOOP4*/);
            return (Mct8329AClosedLoop4)value;
        }

        public void WriteClosedLoop4(Mct8329AClosedLoop4 closedLoop4)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x8C/*CLOSED_LOOP4*/, (uint)closedLoop4);
        }

        public Mct8329AConstPwr ReadConstPwr()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x90/*CONST_PWR*/);
            return (Mct8329AConstPwr)value;
        }

        public void WriteConstPwr(Mct8329AConstPwr constPwr)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x90/*CONST_PWR*/, (uint)constPwr);
        }

        public Mct8329ARefProfiles1 ReadRefProfiles1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x9A/*REF_PROFILES1*/);
            return (Mct8329ARefProfiles1)value;
        }

        public void WriteRefProfiles1(Mct8329ARefProfiles1 refProfiles1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x9A/*REF_PROFILES1*/, (uint)refProfiles1);
        }
    }
}
