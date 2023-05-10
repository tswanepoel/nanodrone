namespace Biscuits.Devices
{
    using System;
    using FaultConfiguration;

    public partial class Mct8329A
    {
        public Mct8329AFaultConfig1 ReadFaultConfig1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x92/*FAULT_CONFIG1*/);
            return (Mct8329AFaultConfig1)value;
        }

        public void WriteFaultConfig1(Mct8329AFaultConfig1 faultConfig1)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x92/*FAULT_CONFIG1*/, (uint)faultConfig1);
        }

        public Mct8329AFaultConfig2 ReadFaultConfig2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x94/*FAULT_CONFIG2*/);
            return (Mct8329AFaultConfig2)value;
        }

        public void WriteFaultConfig2(Mct8329AFaultConfig2 faultConfig2)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            WriteUInt32(0x94/*FAULT_CONFIG2*/, (uint)faultConfig2);
        }
    }
}
