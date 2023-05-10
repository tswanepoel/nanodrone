namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AClosedLoop1
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int CommControlLoc = 29;
        private const uint CommControlMask = 0b11;

        private const int CLAccLoc = 24;
        private const uint CLAccMask = 0x1F;

        private const int CLDecConfigLoc = 23;
        private const uint CLDecConfigMask = 0b1;

        private const int CLDecLoc = 18;
        private const uint CLDecMask = 0x1F;

        private const int PwmFreqOutLoc = 13;
        private const uint PwmFreqOutMask = 0x1F;

        private const int PwmModulLoc = 11;
        private const uint PwmModulMask = 0b11;

        private const int PwmModeLoc = 10;
        private const uint PwmModeMask = 0b1;

        private const int LDAnglePolarityLoc = 9;
        private const uint LDAnglePolarityMask = 0b1;

        private const int LDAngleLoc = 1;
        private const uint LDAngleMask = 0xFF;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mca8329ACLAcc CLAcc
        {
            get => (Mca8329ACLAcc)(_value >> CLAccLoc & CLAccMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CLAccMask << CLAccLoc)) | ((valueUInt32 & CLAccMask) << CLAccLoc);
            }
        }

        public Mca8329APwmFreqOut PwmFreqOut
        {
            get => (Mca8329APwmFreqOut)(_value >> PwmFreqOutLoc & PwmFreqOutMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(PwmFreqOutMask << PwmFreqOutLoc)) | ((valueUInt32 & PwmFreqOutMask) << PwmFreqOutLoc);
            }
        }

        private Mct8329AClosedLoop1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AClosedLoop1(uint value)
        {
            return new Mct8329AClosedLoop1(value);
        }

        public static implicit operator uint(Mct8329AClosedLoop1 closedLoop1)
        {
            return closedLoop1._value;
        }
    }
}
