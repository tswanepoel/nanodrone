namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AMotorStartup1
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int AlignRampRateLoc = 27;
        private const uint AlignRampRateMask = 0xF;

        private const int AlignTimeLoc = 23;
        private const uint AlignTimeMask = 0xF;

        private const int AlignCurrThrLoc = 18;
        private const uint AlignCurrThrMask = 0x1F;

        private const int AlignDutyLoc = 16;
        private const uint AlignDutyMask = 0b11;

        private const int IpdClkFreqLoc = 13;
        private const uint IpdClkFreqMask = 0b111;

        private const int IpdCurrThrLoc = 8;
        private const uint IpdCurrThrMask = 0x1F;

        private const int IpdAdvAngleLoc = 6;
        private const uint IpdAdvAngleMask = 0b11;

        private const int IpdRepeatLoc = 4;
        private const uint IpdRepeatMask = 0b11;

        private const int SlowFirstCycFreqLoc = 0;
        private const uint SlowFirstCycFreqMask = 0xF;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329AAlignRampRate AlignRampRate
        {
            get => (Mct8329AAlignRampRate)(_value >> AlignRampRateLoc & AlignRampRateMask);
        }

        public Mct8329AAlignTime AlignTime
        {
            get => (Mct8329AAlignTime)(_value >> AlignTimeLoc & AlignTimeMask);
        }

        public Mct8329ACurrThr AlignCurrThr
        {
            get => (Mct8329ACurrThr)(_value >> AlignCurrThrLoc & AlignCurrThrMask);
        }

        public Mct8329AAlignDuty AlignDuty
        {
            get => (Mct8329AAlignDuty)(_value >> AlignDutyLoc & AlignDutyMask);
        }

        public Mct8329AIpdClkFreq IpdClkFreq
        {
            get => (Mct8329AIpdClkFreq)(_value >> IpdClkFreqLoc & IpdClkFreqMask);
        }

        public Mct8329ACurrThr IpdCurrThr
        {
            get => (Mct8329ACurrThr)(_value >> IpdCurrThrLoc & IpdCurrThrMask);
        }

        public Mct8329AIpdAdvAngle IpdAdvAngle
        {
            get => (Mct8329AIpdAdvAngle)(_value >> IpdAdvAngleLoc & IpdAdvAngleMask);
        }

        public Mct8329AIpdRepeat IpdRepeat
        {
            get => (Mct8329AIpdRepeat)(_value >> IpdRepeatLoc & IpdRepeatMask);
        }

        public Mct8329ASlowFirstCycFreq SlowFirstCycFreq
        {
            get => (Mct8329ASlowFirstCycFreq)(_value >> SlowFirstCycFreqLoc & SlowFirstCycFreqMask);
        }

        private Mct8329AMotorStartup1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AMotorStartup1(uint value)
        {
            return new Mct8329AMotorStartup1(value);
        }

        public static implicit operator uint(Mct8329AMotorStartup1 config)
        {
            return config._value;
        }
    }
}
