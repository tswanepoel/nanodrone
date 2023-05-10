namespace Biscuits.Devices
{
    public readonly struct Mct8329AGateDriverFaultStatus
    {
        private const int DriverFaultLoc = 31;
        private const uint DriverFaultMask = 0b1;

        private const int PwrOnLoc = 30;
        private const uint PwrOnMask = 0b1;

        private const int OcpVdsFaultLoc = 28;
        private const uint OcpVdsFaultMask = 0b1;

        private const int OcpSnsFaultLoc = 27;
        private const uint OcpSnsFaultMask = 0b1;

        private const int BstUVFaultLoc = 26;
        private const uint BstUVFaultMask = 0b1;

        private const int GVddUVFaultLoc = 25;
        private const uint GVddUVFaultMask = 0b1;

        private const int DrvOffLoc = 24;
        private const uint DrvOffMask = 0b1;

        private readonly uint _value;

        public bool DriverFault
        {
            get => ((_value >> DriverFaultLoc) & DriverFaultMask) != 0;
        }

        public bool PwrOn
        {
            get => ((_value >> PwrOnLoc) & PwrOnMask) != 0;
        }

        public bool OcpVdsFault
        {
            get => ((_value >> OcpVdsFaultLoc) & OcpVdsFaultMask) != 0;
        }

        public bool OcpSnsFault
        {
            get => ((_value >> OcpSnsFaultLoc) & OcpSnsFaultMask) != 0;
        }

        public bool BstUVFault
        {
            get => ((_value >> BstUVFaultLoc) & BstUVFaultMask) != 0;
        }

        public bool GVddUVFault
        {
            get => ((_value >> GVddUVFaultLoc) & GVddUVFaultMask) != 0;
        }

        public bool DrvOff
        {
            get => ((_value >> DrvOffLoc) & DrvOffMask) != 0;
        }

        private Mct8329AGateDriverFaultStatus(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AGateDriverFaultStatus(uint value)
        {
            return new Mct8329AGateDriverFaultStatus(value);
        }

        public static implicit operator uint(Mct8329AGateDriverFaultStatus gateDriverFaultStatus)
        {
            return gateDriverFaultStatus._value;
        }
    }
}
