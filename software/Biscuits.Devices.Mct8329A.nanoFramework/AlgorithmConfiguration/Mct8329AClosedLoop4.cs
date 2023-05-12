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

        private const int AvsNegCurrLimitLoc = 25;
        private const uint AvsNegCurrLimitMask = 0b111;

        private const int FastDecDegTimeLoc = 20;
        private const uint FastDecDegTimeMask = 0b11;

        private const int WCompBlankEnLoc = 19;
        private const uint WCompBlankEnMask = 0b1;

        private const int FastDecDutyWinLoc = 16;
        private const uint FastDecDutyWinMask = 0b111;

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

        public bool DynVoltScalingEn
        {
            get => (_value >> DynVoltScalingEnLoc & DynVoltScalingEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(DynVoltScalingEnMask << DynVoltScalingEnLoc)) | ((valueUInt32 & DynVoltScalingEnMask) << DynVoltScalingEnLoc);
            }
        }

        public Mct8329AHighResSamp HighResSamp
        {
            get => (Mct8329AHighResSamp)(_value >> HighResSampLoc & HighResSampMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(HighResSampMask << HighResSampLoc)) | ((valueUInt32 & HighResSampMask) << HighResSampLoc);
            }
        }

        public Mct8329AAvsLimitHyst AvsLimitHyst
        {
            get => (Mct8329AAvsLimitHyst)(_value >> AvsLimitHystLoc & AvsLimitHystMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(AvsLimitHystMask << AvsLimitHystLoc)) | ((valueUInt32 & AvsLimitHystMask) << AvsLimitHystLoc);
            }
        }

        public Mct8329AAvsNegCurrLimit AvsNegCurrLimit
        {
            get => (Mct8329AAvsNegCurrLimit)(_value >> AvsNegCurrLimitLoc & AvsNegCurrLimitMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(AvsNegCurrLimitMask << AvsNegCurrLimitLoc)) | ((valueUInt32 & AvsNegCurrLimitMask) << AvsNegCurrLimitLoc);
            }
        }

        public Mct8329AFastDecDegTime FastDecDegTime
        {
            get => (Mct8329AFastDecDegTime)(_value >> FastDecDegTimeLoc & FastDecDegTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FastDecDegTimeMask << FastDecDegTimeLoc)) | ((valueUInt32 & FastDecDegTimeMask) << FastDecDegTimeLoc);
            }
        }

        public bool WCompBlankEn
        {
            get => (_value >> WCompBlankEnLoc & WCompBlankEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(WCompBlankEnMask << WCompBlankEnLoc)) | ((valueUInt32 & WCompBlankEnMask) << WCompBlankEnLoc);
            }
        }

        public Mct8329AFastDecDutyWin FastDecDutyWin
        {
            get => (Mct8329AFastDecDutyWin)(_value >> FastDecDutyWinLoc & FastDecDutyWinMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FastDecDutyWinMask << FastDecDutyWinLoc)) | ((valueUInt32 & FastDecDutyWinMask) << FastDecDutyWinLoc);
            }
        }

        public Mct8329AFastDecDutyThr FastDecDutyThr
        {
            get => (Mct8329AFastDecDutyThr)(_value >> FastDecDutyThrLoc & FastDecDutyThrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FastDecDutyThrMask << FastDecDutyThrLoc)) | ((valueUInt32 & FastDecDutyThrMask) << FastDecDutyThrLoc);
            }
        }

        public Mct8329ADynBrkCurrLowLim DynBrkCurrLowLim
        {
            get => (Mct8329ADynBrkCurrLowLim)(_value >> DynBrkCurrLowLimLoc & DynBrkCurrLowLimMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DynBrkCurrLowLimMask << DynBrkCurrLowLimLoc)) | ((valueUInt32 & DynBrkCurrLowLimMask) << DynBrkCurrLowLimLoc);
            }
        }

        public bool DynamicBrkCurr
        {
            get => (_value >> DynamicBrkCurrLoc & DynamicBrkCurrMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(DynamicBrkCurrMask << DynamicBrkCurrLoc)) | ((valueUInt32 & DynamicBrkCurrMask) << DynamicBrkCurrLoc);
            }
        }

        public bool FastDecelEn
        {
            get => (_value >> FastDecelEnLoc & FastDecelEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(FastDecelEnMask << FastDecelEnLoc)) | ((valueUInt32 & FastDecelEnMask) << FastDecelEnLoc);
            }
        }

        public Mct8329AFastDecelCurrLim FastDecelCurrLim
        {
            get => (Mct8329AFastDecelCurrLim)(_value >> FastDecelCurrLimLoc & FastDecelCurrLimMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FastDecelCurrLimMask << FastDecelCurrLimLoc)) | ((valueUInt32 & FastDecelCurrLimMask) << FastDecelCurrLimLoc);
            }
        }

        public Mct8329AFastBrkDelta FastBrkDelta
        {
            get => (Mct8329AFastBrkDelta)(_value >> FastBrkDeltaLoc & FastBrkDeltaMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FastBrkDeltaMask << FastBrkDeltaLoc)) | ((valueUInt32 & FastBrkDeltaMask) << FastBrkDeltaLoc);
            }
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
