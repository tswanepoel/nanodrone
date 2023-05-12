namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AClosedLoop3
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int IntegCyclThrLowLoc = 29;
        private const uint IntegCyclThrLowMask = 0b11;

        private const int IntegCyclThrHighLoc = 27;
        private const uint IntegCyclThrHighMask = 0b11;

        private const int IntegDutyThrLowLoc = 25;
        private const uint IntegDutyThrLowMask = 0b11;

        private const int IntegDutyThrHighLoc = 23;
        private const uint IntegDutyThrHighMask = 0b11;

        private const int BemfThreshold2Loc = 17;
        private const uint BemfThreshold2Mask = 0x3F;

        private const int BemfThreshold1Loc = 11;
        private const uint BemfThreshold1Mask = 0x3F;

        private const int DynDgsFiltCountLoc = 8;
        private const uint DynDgsFiltCountMask = 0b111;

        private const int DynDgsUpperLimLoc = 6;
        private const uint DynDgsUpperLimMask = 0b11;

        private const int DynDgsLowerLimLoc = 4;
        private const uint DynDgsLowerLimMask = 0b11;

        private const int DegaussMaxWinLoc = 1;
        private const uint DegaussMaxWinMask = 0b111;

        private const int DynDegaussEnLoc = 0;
        private const uint DynDegaussEnMask = 0b1;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329AIntegCyclThrLow IntegCyclThrLow
        {
            get => (Mct8329AIntegCyclThrLow)(_value >> IntegCyclThrLowLoc & IntegCyclThrLowMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(IntegCyclThrLowMask << IntegCyclThrLowLoc)) | ((valueUInt32 & IntegCyclThrLowMask) << IntegCyclThrLowLoc);
            }
        }

        public Mct8329AIntegCyclThrHigh IntegCyclThrHigh
        {
            get => (Mct8329AIntegCyclThrHigh)(_value >> IntegCyclThrHighLoc & IntegCyclThrHighMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(IntegCyclThrHighMask << IntegCyclThrHighLoc)) | ((valueUInt32 & IntegCyclThrHighMask) << IntegCyclThrHighLoc);
            }
        }

        public Mct8329AIntegDutyThrLow IntegDutyThrLow
        {
            get => (Mct8329AIntegDutyThrLow)(_value >> IntegDutyThrLowLoc & IntegDutyThrLowMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(IntegDutyThrLowMask << IntegDutyThrLowLoc)) | ((valueUInt32 & IntegDutyThrLowMask) << IntegDutyThrLowLoc);
            }
        }

        public Mct8329AIntegDutyThrHigh IntegDutyThrHigh
        {
            get => (Mct8329AIntegDutyThrHigh)(_value >> IntegDutyThrHighLoc & IntegDutyThrHighMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(IntegDutyThrHighMask << IntegDutyThrHighLoc)) | ((valueUInt32 & IntegDutyThrHighMask) << IntegDutyThrHighLoc);
            }
        }

        public Mct8329ABemfThreshold BemfThreshold2
        {
            get => (Mct8329ABemfThreshold)(_value >> BemfThreshold2Loc & BemfThreshold2Mask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(BemfThreshold2Mask << BemfThreshold2Loc)) | ((valueUInt32 & BemfThreshold2Mask) << BemfThreshold2Loc);
            }
        }

        public Mct8329ABemfThreshold BemfThreshold1
        {
            get => (Mct8329ABemfThreshold)(_value >> BemfThreshold1Loc & BemfThreshold1Mask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(BemfThreshold1Mask << BemfThreshold1Loc)) | ((valueUInt32 & BemfThreshold1Mask) << BemfThreshold1Loc);
            }
        }

        public Mct8329ADynDgsFiltCount DynDgsFiltCount
        {
            get => (Mct8329ADynDgsFiltCount)(_value >> DynDgsFiltCountLoc & DynDgsFiltCountMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DynDgsFiltCountMask << DynDgsFiltCountLoc)) | ((valueUInt32 & DynDgsFiltCountMask) << DynDgsFiltCountLoc);
            }
        }

        public Mct8329ADynDgsUpperLim DynDgsUpperLim
        {
            get => (Mct8329ADynDgsUpperLim)(_value >> DynDgsUpperLimLoc & DynDgsUpperLimMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DynDgsUpperLimMask << DynDgsUpperLimLoc)) | ((valueUInt32 & DynDgsUpperLimMask) << DynDgsUpperLimLoc);
            }
        }

        public Mct8329ADynDgsLowerLim DynDgsLowerLim
        {
            get => (Mct8329ADynDgsLowerLim)(_value >> DynDgsLowerLimLoc & DynDgsLowerLimMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DynDgsLowerLimMask << DynDgsLowerLimLoc)) | ((valueUInt32 & DynDgsLowerLimMask) << DynDgsLowerLimLoc);
            }
        }

        public Mct8329ADegaussMaxWin DegaussMaxWin
        {
            get => (Mct8329ADegaussMaxWin)(_value >> DegaussMaxWinLoc & DegaussMaxWinMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DegaussMaxWinMask << DegaussMaxWinLoc)) | ((valueUInt32 & DegaussMaxWinMask) << DegaussMaxWinLoc);
            }
        }

        public bool DynDegaussEn
        {
            get => (_value >> DynDegaussEnLoc & DynDegaussEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(DynDegaussEnMask << DynDegaussEnLoc)) | ((valueUInt32 & DynDegaussEnMask) << DynDegaussEnLoc);
            }
        }

        private Mct8329AClosedLoop3(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AClosedLoop3(uint value)
        {
            return new Mct8329AClosedLoop3(value);
        }

        public static implicit operator uint(Mct8329AClosedLoop3 closedLoop3)
        {
            return closedLoop3._value;
        }
    }
}
