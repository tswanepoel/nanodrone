namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AClosedLoop4
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int DynVoltScalingEnLoc = 30;
        private const uint DynVoltScalingEnMask = 0b1;

        private const int HighResSampLoc = 29;
        private const uint HighResSampMask = 0b1;

        private const int AvsLimitHystLoc = 28;
        private const uint AvsLimitHystMask = 0b1;

        private const int AvgNegCurrLimitLoc = 25;
        private const uint AvgNegCurrLimitMask = 0b111;

        private const int FastDecDegTimeLoc = 20;
        private const uint FastDecDegTimeMask = 0b11;

        private const int WCompBlankEnLoc = 19;
        private const uint WCompBlankEnMask = 0b1;

        private const int FastDecDutyMinLoc = 16;
        private const uint FastDecDutyMinMask = 0b111;

        private const int FastDecDutyThrLoc = 13;
        private const uint FastDecDutyThrMask = 0b111;

        private const int DynBrkCurrLowLimLoc = 9;
        private const uint DynBrkCurrLowLimMask = 0xF;

        private const int DynamicBrkCurrLoc = 8;
        private const uint DynamicBrkCurrMask = 0b1;

        private const int FastDecelEnLoc = 7;
        private const uint FastDecelEnMask = 0b1;

        private const int FastDecelCurrLimLoc = 3;
        private const uint FastDecelCurrLimMask = 0xF;

        private const int FastBrkDeltaLoc = 0;
        private const uint FastBrkDeltaMask = 0b111;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        private Mct8329AClosedLoop4(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AClosedLoop4(uint value)
        {
            return new Mct8329AClosedLoop4(value);
        }

        public static implicit operator uint(Mct8329AClosedLoop4 closedLoop4)
        {
            return closedLoop4._value;
        }
    }
}
