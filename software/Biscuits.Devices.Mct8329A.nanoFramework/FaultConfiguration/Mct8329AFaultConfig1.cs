namespace Biscuits.Devices.FaultConfiguration
{
    public struct Mct8329AFaultConfig1
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int NoMtrDegTimeLoc = 28;
        private const uint NoMtrDegTimeMask = 0b111;

        private const int CbcILimitModeLoc = 24;
        private const uint CbcILimitModeMask = 0xF;

        private const int LockILimitLoc = 19;
        private const uint LockILimitMask = 0x1F;

        private const int LockILimitModeLoc = 15;
        private const uint LockILimitModeMask = 0xF;

        private const int LockILimitDegLoc = 11;
        private const uint LockILimitDegMask = 0xF;

        private const int CbcRetryPwmCycLoc = 8;
        private const uint CbcRetryPwmCycMask = 0b111;

        private const int MtrLckModeLoc = 3;
        private const uint MtrLckModeMask = 0xF;

        private const int LckRetryLoc = 0;
        private const uint LckRetryMask = 0b111;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ANoMtrDegTime NoMtrDegTime
        {
            get => (Mct8329ANoMtrDegTime)(_value >> NoMtrDegTimeLoc & NoMtrDegTimeMask);
        }

        public Mct8329ACbcILimitMode CbcILimitMode
        {
            get => (Mct8329ACbcILimitMode)(_value >> CbcILimitModeLoc & CbcILimitModeMask);
        }

        public Mct8329ALockILimit LockILimit
        {
            get => (Mct8329ALockILimit)(_value >> LockILimitLoc & LockILimitMask);
        }

        public Mct8329ALockILimitMode LockILimitMode
        {
            get => (Mct8329ALockILimitMode)(_value >> LockILimitModeLoc & LockILimitModeMask);
        }

        public Mct8329ALockILimitDeg LockILimitDeg
        {
            get => (Mct8329ALockILimitDeg)(_value >> LockILimitDegLoc & LockILimitDegMask);
        }

        public int CbcRetryPwmCyc
        {
            get => (int)(_value >> CbcRetryPwmCycLoc & CbcRetryPwmCycMask);
        }

        public Mct8329AMtrLckMode MtrLckMode
        {
            get => (Mct8329AMtrLckMode)(_value >> MtrLckModeLoc & MtrLckModeMask);
        }

        public Mct8329ALckRetry LckRetry
        {
            get => (Mct8329ALckRetry)(_value >> LckRetryLoc & LckRetryMask);
        }

        private Mct8329AFaultConfig1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AFaultConfig1(uint value)
        {
            return new Mct8329AFaultConfig1(value);
        }

        public static implicit operator uint(Mct8329AFaultConfig1 config)
        {
            return config._value;
        }
    }
}
