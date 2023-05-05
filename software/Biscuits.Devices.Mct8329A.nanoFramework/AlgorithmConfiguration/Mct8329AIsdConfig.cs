namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AIsdConfig
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int IsdEnLoc = 30;
        private const uint IsdEnMask = 0b1;

        private const int BrakeEnLoc = 29;
        private const uint BrakeEnMask = 0b1;

        private const int HiZEnLoc = 28;
        private const uint HiZEnMask = 0b1;

        private const int RvsDrEnLoc = 27;
        private const uint RvsDrEnMask = 0b1;

        private const int ResyncEnLoc = 26;
        private const uint ResyncEnMask = 0b1;

        private const int StatBrkEnLoc = 25;
        private const uint StatBrkEnMask = 0b1;

        private const int StatDetectThrLoc = 22;
        private const uint StatDetectThrMask = 0b111;

        private const int BrkModeLoc = 21;
        private const uint BrkModeMask = 0b1;

        private const int BrkTimeLoc = 13;
        private const uint BrkTimeMask = 0xF;

        private const int HiZTimeLoc = 9;
        private const uint HiZTimeMask = 0xF;

        private const int StartupBrkTimeLoc = 6;
        private const uint StartupBrkTimeMask = 0b111;

        private const int ResyncMinThresholdLoc = 3;
        private const uint ResyncMinThresholdMask = 0b111;

        private const int MtrStartupLoc = 1;
        private const uint MtrStartupMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public bool IsdEn
        {
            get => (_value >> IsdEnLoc & IsdEnMask) != 0;
        }

        public bool BrakeEn
        {
            get => (_value >> BrakeEnLoc & BrakeEnMask) != 0;
        }

        public bool HiZEn
        {
            get => (_value >> HiZEnLoc & HiZEnMask) != 0;
        }

        public bool RvsDrEn
        {
            get => (_value >> RvsDrEnLoc & RvsDrEnMask) != 0;
        }

        public bool ResyncEn
        {
            get => (_value >> ResyncEnLoc & ResyncEnMask) != 0;
        }

        public bool StatBrkEn
        {
            get => (_value >> StatBrkEnLoc & StatBrkEnMask) != 0;
        }

        public Mct8329AStatDetectThr StatDetectThr
        {
            get => (Mct8329AStatDetectThr)(_value >> StatDetectThrLoc & StatDetectThrMask);
        }

        public Mct8329ABrkMode BrkMode
        {
            get => (Mct8329ABrkMode)(_value >> BrkModeLoc & BrkModeMask);
        }

        public Mct8329ABrkTime BrkTime
        {
            get => (Mct8329ABrkTime)(_value >> BrkTimeLoc & BrkTimeMask);
        }

        public Mct8329AHiZTime HiZTime
        {
            get => (Mct8329AHiZTime)(_value >> HiZTimeLoc & HiZTimeMask);
        }

        public Mct8329AStartupBrkTime StartupBrkTime
        {
            get => (Mct8329AStartupBrkTime)(_value >> StartupBrkTimeLoc & StartupBrkTimeMask);
        }

        public Mct8329AResyncMinThreshold ResyncMinThreshold
        {
            get => (Mct8329AResyncMinThreshold)(_value >> ResyncMinThresholdLoc & ResyncMinThresholdMask);
        }

        public Mct8329AMtrStartup MtrStartup
        {
            get => (Mct8329AMtrStartup)(_value >> MtrStartupLoc & MtrStartupMask);
        }

        private Mct8329AIsdConfig(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AIsdConfig(uint value)
        {
            return new Mct8329AIsdConfig(value);
        }

        public static implicit operator uint(Mct8329AIsdConfig config)
        {
            return config._value;
        }
    }
}
