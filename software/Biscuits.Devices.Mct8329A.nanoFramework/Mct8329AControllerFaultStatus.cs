namespace Biscuits.Devices
{
    public readonly struct Mct8329AControllerFaultStatus
    {
        private const int ControllerFaultLoc = 13;
        private const uint ControllerFaultMask = 0b1;

        private const int IpdFreqFaultLoc = 29;
        private const uint IpdFreqFaultMask = 0b1;

        private const int IpdT1FaultLoc = 28;
        private const uint IpdT1FaultMask = 0b1;

        private const int AbnSpeedLoc = 23;
        private const uint AbnSpeedMask = 0b1;

        private const int LossOfSyncLoc = 22;
        private const uint LossOfSyncMask = 0b1;

        private const int NoMtrLoc = 21;
        private const uint NoMtrMask = 0b1;

        private const int MtrLckLoc = 20;
        private const uint MtrLckMask = 0b1;

        private const int CbcILimitLoc = 19;
        private const uint CbcILimitMask = 0b1;

        private const int LockILimitLoc = 18;
        private const uint LockILimitMask = 0b1;

        private const int MtrUnderVoltageLoc = 17;
        private const uint MtrUnderVoltageMask = 0b1;

        private const int MtrOverVoltageLoc = 16;
        private const uint MtrOverVoltageMask = 0b1;

        private const int StlEnLoc = 2;
        private const uint StlEnMask = 0b1;

        private const int StlStatusLoc = 1;
        private const uint StlStatusMask = 0b1;

        private const int AppResetLoc = 0;
        private const uint AppResetMask = 0b1;

        private readonly uint _value;

        public bool ControllerFault
        {
            get => ((_value >> ControllerFaultLoc) & ControllerFaultMask) != 0;
        }

        public bool IpdFreqFault
        {
            get => ((_value >> IpdFreqFaultLoc) & IpdFreqFaultMask) != 0;
        }

        public bool IpdT1Fault
        {
            get => ((_value >> IpdT1FaultLoc) & IpdT1FaultMask) != 0;
        }

        public bool AbnSpeed
        {
            get => ((_value >> AbnSpeedLoc) & AbnSpeedMask) != 0;
        }

        public bool LossOfSync
        {
            get => ((_value >> LossOfSyncLoc) & LossOfSyncMask) != 0;
        }

        public bool NoMtr
        {
            get => ((_value >> NoMtrLoc) & NoMtrMask) != 0;
        }

        public bool MtrLck
        {
            get => ((_value >> MtrLckLoc) & MtrLckMask) != 0;
        }

        public bool CbcILimit
        {
            get => ((_value >> CbcILimitLoc) & CbcILimitMask) != 0;
        }

        public bool LockILimit
        {
            get => ((_value >> LockILimitLoc) & LockILimitMask) != 0;
        }

        public bool MtrUnderVoltage
        {
            get => ((_value >> MtrUnderVoltageLoc) & MtrUnderVoltageMask) != 0;
        }

        public bool MtrOverVoltage
        {
            get => ((_value >> MtrOverVoltageLoc) & MtrOverVoltageMask) != 0;
        }

        public bool StlEn
        {
            get => ((_value >> StlEnLoc) & StlEnMask) != 0;
        }

        public bool StlStatus
        {
            get => ((_value >> StlStatusLoc) & StlStatusMask) != 0;
        }

        public bool AppReset
        {
            get => ((_value >> AppResetLoc) & AppResetMask) != 0;
        }

        private Mct8329AControllerFaultStatus(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AControllerFaultStatus(uint value)
        {
            return new Mct8329AControllerFaultStatus(value);
        }

        public static implicit operator uint(Mct8329AControllerFaultStatus config)
        {
            return config._value;
        }
    }
}
