namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AClosedLoop3
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int IntegCyclThrLowLoc = 29;
        private const uint IntegCyclThrLowMask = 0b11;

        private const int IntegCyclThrHigLoc = 27;
        private const uint IntegCyclThrHigMask = 0b11;

        private const int IntegDutyThrLowLoc = 25;
        private const uint IntegDutyThrLowMask = 0b11;

        private const int IntegDutyThrHigLoc = 23;
        private const uint IntegDutyThrHigMask = 0b11;

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
