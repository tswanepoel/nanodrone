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
        private const uint FGBemfThrMask = 0b111;

        private const int MtrStopLoc = 18;
        private const uint MtrStopMask = 0b111;

        private const int MtrStopBrkTimeLoc = 14;
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

        public Mct8329AFGSel FGSel
        {
            get => (Mct8329AFGSel)(_value >> FGSelLoc & FGSelMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FGSelMask << FGSelLoc)) | ((valueUInt32 & FGSelMask) << FGSelLoc);
            }
        }

        public Mct8329AFGDivFactor FGDivFactor
        {
            get => (Mct8329AFGDivFactor)(_value >> FGDivFactorLoc & FGDivFactorMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FGDivFactorMask << FGDivFactorLoc)) | ((valueUInt32 & FGDivFactorMask) << FGDivFactorLoc);
            }
        }

        public bool DeadTimeComp
        {
            get => (_value >> DeadTimeCompLoc & DeadTimeCompMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(DeadTimeCompMask << DeadTimeCompLoc)) | ((valueUInt32 & DeadTimeCompMask) << DeadTimeCompLoc);
            }
        }

        public Mct8329AFGBemfThr FGBemfThr
        {
            get => (Mct8329AFGBemfThr)(_value >> FGBemfThrLoc & FGBemfThrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FGBemfThrMask << FGBemfThrLoc)) | ((valueUInt32 & FGBemfThrMask) << FGBemfThrLoc);
            }
        }

        public Mct8329AMtrStop MtrStop
        {
            get => (Mct8329AMtrStop)(_value >> MtrStopLoc & MtrStopMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MtrStopMask << MtrStopLoc)) | ((valueUInt32 & MtrStopMask) << MtrStopLoc);
            }
        }

        public Mct8329AMtrStopBrkTime MtrStopBrkTime
        {
            get => (Mct8329AMtrStopBrkTime)(_value >> MtrStopBrkTimeLoc & MtrStopBrkTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MtrStopBrkTimeMask << MtrStopBrkTimeLoc)) | ((valueUInt32 & MtrStopBrkTimeMask) << MtrStopBrkTimeLoc);
            }
        }

        public Mct8329AActSpinBrkThr ActSpinBrkThr
        {
            get => (Mct8329AActSpinBrkThr)(_value >> ActSpinBrkThrLoc & ActSpinBrkThrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ActSpinBrkThrMask << ActSpinBrkThrLoc)) | ((valueUInt32 & ActSpinBrkThrMask) << ActSpinBrkThrLoc);
            }
        }

        public Mct8329ABrakeDutyThreshold BrakeDutyThreshold
        {
            get => (Mct8329ABrakeDutyThreshold)(_value >> BrakeDutyThresholdLoc & BrakeDutyThresholdMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(BrakeDutyThresholdMask << BrakeDutyThresholdLoc)) | ((valueUInt32 & BrakeDutyThresholdMask) << BrakeDutyThresholdLoc);
            }
        }

        public bool AvsEn
        {
            get => (_value >> AvsEnLoc & AvsEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(AvsEnMask << AvsEnLoc)) | ((valueUInt32 & AvsEnMask) << AvsEnLoc);
            }
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

        public Mct8329AOLILimitConfig OLILimitConfig
        {
            get => (Mct8329AOLILimitConfig)(_value >> OLILimitConfigLoc & OLILimitConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OLILimitConfigMask << OLILimitConfigLoc)) | ((valueUInt32 & OLILimitConfigMask) << OLILimitConfigLoc);
            }
        }

        public Mct8329AIntegZCMethod IntegZCMethod
        {
            get => (Mct8329AIntegZCMethod)(_value >> IntegZCMethodLoc & IntegZCMethodMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(IntegZCMethodMask << IntegZCMethodLoc)) | ((valueUInt32 & IntegZCMethodMask) << IntegZCMethodLoc);
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
