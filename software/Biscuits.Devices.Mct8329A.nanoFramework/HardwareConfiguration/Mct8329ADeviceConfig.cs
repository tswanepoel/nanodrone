namespace Biscuits.Devices.HardwareConfiguration
{
    public struct Mct8329ADeviceConfig
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int InputMaxFrequencyLoc = 16;
        private const uint InputMinFrequencyMask = 0xFFFE;

        private const int StlEnableLoc = 15;
        private const uint StlEnableMask = 0b1;

        private const int SsmConfigLoc = 14;
        private const uint SsmConfigMask = 0b1;

        private const int DevModeLoc = 11;
        private const uint DevModeMask = 0b1;

        private const int SpdPwmRangeSelectLoc = 10;
        private const uint SpdPwmRangeSelectMask = 0b1;

        private const int ClkSelLoc = 8;
        private const uint ClkSelMask = 0b11;

        private const int ExtClkEnLoc = 7;
        private const uint ExtClkEnMask = 0b1;

        private const int ExtClkConfigLoc = 4;
        private const uint ExtClkConfigMask = 0b11;

        private const int DigDeadTimeLoc = 0;
        private const uint DigDeadTimeMask = 0xF;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public int InputMaxFrequency
        {
            get => (int)(_value >> InputMaxFrequencyLoc & InputMinFrequencyMask);
        }

        public bool StlEnable
        {
            get => (_value >> StlEnableLoc & StlEnableMask) != 0;
        }

        public bool SsmConfig
        {
            get => (_value >> SsmConfigLoc & SsmConfigMask) != 0;
        }

        public Mct8329ADevMode DevMode
        {
            get => (Mct8329ADevMode)(_value >> DevModeLoc & DevModeMask);
        }

        public Mct8329ASpdPwmRangeSelect SpdPwmRangeSelect
        {
            get => (Mct8329ASpdPwmRangeSelect)(_value >> SpdPwmRangeSelectLoc & SpdPwmRangeSelectMask);
        }

        public Mct8329AClkSel ClkSel
        {
            get => (Mct8329AClkSel)(_value >> ClkSelLoc & ClkSelMask);
        }

        public bool ExtClkEn
        {
            get => (_value >> ExtClkEnLoc & ExtClkEnMask) != 0;
        }

        public Mct8329AExtClkConfig ExtClkConfig
        {
            get => (Mct8329AExtClkConfig)(_value >> ExtClkConfigLoc & ExtClkConfigMask);
        }

        public Mct8329ADigDeadTime DigDeadTime
        {
            get => (Mct8329ADigDeadTime)(_value >> DigDeadTimeLoc & DigDeadTimeMask);
        }

        private Mct8329ADeviceConfig(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329ADeviceConfig(uint value)
        {
            return new Mct8329ADeviceConfig(value);
        }

        public static implicit operator uint(Mct8329ADeviceConfig config)
        {
            return config._value;
        }
    }
}
