namespace Biscuits.Devices
{
    using System;
    using GateDriverConfiguration;

    public partial class Mct8329A
    {
        public Mct8329AGDConfig1 ReadGDConfig1()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException();
            }

            uint value = ReadUInt32(0xAC/*GD_CONFIG1*/);
            return (Mct8329AGDConfig1)value;
        }
    }
}
