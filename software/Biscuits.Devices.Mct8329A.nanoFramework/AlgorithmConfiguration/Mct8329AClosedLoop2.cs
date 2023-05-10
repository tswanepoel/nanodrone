namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AClosedLoop2
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int FGSelLoc = 29;
        private const uint FGSelMask = 0b11;

        private const int FGDivFactorLoc = 25;
        private const uint FGDivFactorMask = 0xF;

        private const int DeadTimeCompLoc = 24;
        private const uint DeadTimeCompMask = 0b1;

        private const int FGBemfThrLoc = 21;
        private const uint FGBemfMask = 0b111;

        private const int MtrStopLoc = 18;
        private const uint MtrStopMask = 0b111;

        private const int MtrStopBrkTimelLoc = 14;
        private const uint MtrStopBrkTimeMask = 0xF;

        private const int ActSpinBrkThrLoc = 11;
        private const uint ActSpinBrkThrMask = 0b1;

        private const int BrakeDutyThresholdLoc = 8;
        private const uint BrakeDutyThresholdMask = 0b111;

        private const int AvsEnLoc = 7;
        private const uint AvsEnMask = 0b1;

        private const int CbcILimitLoc = 2;
        private const uint CbcILimitMask = 0x1F;

        private const int OLILimitConfigLoc = 1;
        private const uint OLILimitConfigMask = 0b0;

        private const int IntegZCMethodLoc = 0;
        private const uint IntegZCMethodMask = 0b0;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ACbcILimit CbcILimit
        {
            get => (Mct8329ACbcILimit)(_value >> CbcILimitLoc & CbcILimitMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CbcILimitMask << CbcILimitLoc)) | ((valueUInt32 & CbcILimitMask) << CbcILimitLoc);
            }
        }

        private Mct8329AClosedLoop2(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AClosedLoop2(uint value)
        {
            return new Mct8329AClosedLoop2(value);
        }

        public static implicit operator uint(Mct8329AClosedLoop2 closedLoop2)
        {
            return closedLoop2._value;
        }
    }
}
