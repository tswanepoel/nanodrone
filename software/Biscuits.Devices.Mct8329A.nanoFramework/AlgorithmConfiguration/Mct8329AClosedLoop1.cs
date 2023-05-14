namespace Biscuits.Devices.AlgorithmConfiguration
{
    using System;

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

        public Mct8329ACommControl CommControl
        {
            get => (Mct8329ACommControl)(_value >> CommControlLoc & CommControlMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CommControlMask << CommControlLoc)) | ((valueUInt32 & CommControlMask) << CommControlLoc);
            }
        }

        public Mct8329ACLAcc CLAcc
        {
            get => (Mct8329ACLAcc)(_value >> CLAccLoc & CLAccMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CLAccMask << CLAccLoc)) | ((valueUInt32 & CLAccMask) << CLAccLoc);
            }
        }

        public Mct8329ACLDecConfig CLDecConfig
        {
            get => (Mct8329ACLDecConfig)(_value >> CLDecConfigLoc & CLDecConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CLDecConfigMask << CLDecConfigLoc)) | ((valueUInt32 & CLDecConfigMask) << CLDecConfigLoc);
            }
        }

        public Mct8329ACLDec CLDec
        {
            get => (Mct8329ACLDec)(_value >> CLDecLoc & CLDecMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CLDecMask << CLDecLoc)) | ((valueUInt32 & CLDecMask) << CLDecLoc);
            }
        }

        public Mct8329APwmFreqOut PwmFreqOut
        {
            get => (Mct8329APwmFreqOut)(_value >> PwmFreqOutLoc & PwmFreqOutMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(PwmFreqOutMask << PwmFreqOutLoc)) | ((valueUInt32 & PwmFreqOutMask) << PwmFreqOutLoc);
            }
        }

        public Mct8329APwmModul PwmModul
        {
            get => (Mct8329APwmModul)(_value >> PwmModulLoc & PwmModulMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(PwmModulMask << PwmModulLoc)) | ((valueUInt32 & PwmModulMask) << PwmModulLoc);
            }
        }

        public Mct8329APwmMode PwmMode
        {
            get => (Mct8329APwmMode)(_value >> PwmModeLoc & PwmModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(PwmModeMask << PwmModeLoc)) | ((valueUInt32 & PwmModeMask) << PwmModeLoc);
            }
        }

        public Mct8329ALDAnglePolarity LDAnglePolarity
        {
            get => (Mct8329ALDAnglePolarity)(_value >> LDAnglePolarityLoc & LDAnglePolarityMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LDAnglePolarityMask << LDAnglePolarityLoc)) | ((valueUInt32 & LDAnglePolarityMask) << LDAnglePolarityLoc);
            }
        }

        public float LDAngle
        {
            get => (_value >> LDAngleLoc & LDAngleMask) * .12f;
            set
            {
                const float maxValue = LDAngleMask * .12f;

                if (value < 0f || value > maxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"LDAngle must be between 0 and {maxValue}.");
                }

                uint valueUInt32 = (uint)(value / .12f);
                _value = (_value & ~(LDAngleMask << LDAngleLoc)) | ((valueUInt32 & LDAngleMask) << LDAngleLoc);
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
