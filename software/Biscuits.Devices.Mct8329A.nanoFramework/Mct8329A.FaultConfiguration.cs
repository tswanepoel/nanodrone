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

        public Mct8329AFaultConfig2 ReadFaultConfig2()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0x94/*FAULT_CONFIG2*/);
            return (Mct8329AFaultConfig2)value;
        }
    }
}
