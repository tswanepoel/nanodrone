namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AMotorStartup2
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int OLDutyLoc = 28;
        private const uint OLDutyMask = 0b111;

        private const int OLILimitLoc = 23;
        private const uint OLILimitMask = 0x1F;

        private const int OLAccA1Loc = 18;
        private const uint OLAccA1Mask = 0x1F;

        private const int OLAccA2Loc = 13;
        private const uint OLAccA2Mask = 0x1F;

        private const int OpnClHandoffThrLoc = 8;
        private const uint OpnClHandoffThrMask = 0x1F;

        private const int AutoHandoffLoc = 7;
        private const uint AutoHandoffMask = 0b1;

        private const int FirstCycleFreqSelLoc = 6;
        private const uint FirstCycleFreqSelMask = 0b1;

        private const int MinDutyLoc = 2;
        private const uint MinDutyMask = 0xF;

        private const int OLHandoffCyclesLoc = 0;
        private const uint OLHandoffCyclesMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329AOLDuty OLDuty
        {
            get => (Mct8329AOLDuty)(_value >> OLDutyLoc & OLDutyMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OLDutyMask << OLDutyLoc)) | ((valueUInt32 & OLDutyMask) << OLDutyLoc);
            }
        }

        public Mct8329ACurrThr OLILimit
        {
            get => (Mct8329ACurrThr)(_value >> OLILimitLoc & OLILimitMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OLILimitMask << OLILimitLoc)) | ((valueUInt32 & OLILimitMask) << OLILimitLoc);
            }
        }

        public Mct8329AOLAccA1 OLAccA1
        {
            get => (Mct8329AOLAccA1)(_value >> OLAccA1Loc & OLAccA1Mask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OLAccA1Mask << OLAccA1Loc)) | ((valueUInt32 & OLAccA1Mask) << OLAccA1Loc);
            }
        }

        public Mct8329AOLAccA2 OLAccA2
        {
            get => (Mct8329AOLAccA2)(_value >> OLAccA2Loc & OLAccA2Mask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OLAccA2Mask << OLAccA2Loc)) | ((valueUInt32 & OLAccA2Mask) << OLAccA2Loc);
            }
        }

        public Mct8329AOpnClHandoffThr OpnClHandoffThr
        {
            get => (Mct8329AOpnClHandoffThr)(_value >> OpnClHandoffThrLoc & OpnClHandoffThrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OpnClHandoffThrMask << OpnClHandoffThrLoc)) | ((valueUInt32 & OpnClHandoffThrMask) << OpnClHandoffThrLoc);
            }
        }

        public bool AutoHandoff
        {
            get => (_value >> AutoHandoffLoc & AutoHandoffMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(AutoHandoffMask << AutoHandoffLoc)) | ((valueUInt32 & AutoHandoffMask) << AutoHandoffLoc);
            }
        }

        public Mct8329AFirstCycleFreqSel FirstCycleFreqSel
        {
            get => (Mct8329AFirstCycleFreqSel)(_value >> FirstCycleFreqSelLoc & FirstCycleFreqSelMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FirstCycleFreqSelMask << FirstCycleFreqSelLoc)) | ((valueUInt32 & FirstCycleFreqSelMask) << FirstCycleFreqSelLoc);
            }
        }

        public Mct8329AMinDuty MinDuty
        {
            get => (Mct8329AMinDuty)(_value >> MinDutyLoc & MinDutyMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MinDutyMask << MinDutyLoc)) | ((valueUInt32 & MinDutyMask) << MinDutyLoc);
            }
        }

        public Mct8329AOLHandoffCycles OLHandoffCycles
        {
            get => (Mct8329AOLHandoffCycles)(_value >> OLHandoffCyclesLoc & OLHandoffCyclesMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OLHandoffCyclesMask << OLHandoffCyclesLoc)) | ((valueUInt32 & OLHandoffCyclesMask) << OLHandoffCyclesLoc);
            }
        }

        private Mct8329AMotorStartup2(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AMotorStartup2(uint value)
        {
            return new Mct8329AMotorStartup2(value);
        }

        public static implicit operator uint(Mct8329AMotorStartup2 motorStartup2)
        {
            return motorStartup2._value;
        }
    }
}
