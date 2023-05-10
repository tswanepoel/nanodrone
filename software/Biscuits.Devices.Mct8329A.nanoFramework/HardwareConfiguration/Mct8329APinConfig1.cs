namespace Biscuits.Devices.HardwareConfiguration
{
    public struct Mct8329APinConfig1
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int DacoutVarAddrLoc = 19;
        private const uint DacoutVarAddrMask = 0xFFF;

        private const int BrakeInputLoc = 5;
        private const uint BrakeInputMask = 0b11;

        private const int DirInputLoc = 3;
        private const uint DirInputMask = 0b11;

        private const int SpdCtrlModeLoc = 1;
        private const uint SpdCtrlModeMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ADacoutVarAddr DacoutVarAddr
        {
            get => (Mct8329ADacoutVarAddr)(_value >> DacoutVarAddrLoc & DacoutVarAddrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DacoutVarAddrMask << DacoutVarAddrLoc)) | ((valueUInt32 & DacoutVarAddrMask) << DacoutVarAddrLoc);
            }
        }

        public Mct8329ABrakeInput BrakeInput
        {
            get => (Mct8329ABrakeInput)(_value >> BrakeInputLoc & BrakeInputMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(BrakeInputMask << BrakeInputLoc)) | ((valueUInt32 & BrakeInputMask) << BrakeInputLoc);
            }
        }

        public Mct8329ADirInput DirInput
        {
            get => (Mct8329ADirInput)(_value >> DirInputLoc & DirInputMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DirInputMask << DirInputLoc)) | ((valueUInt32 & DirInputMask) << DirInputLoc);
            }
        }

        public Mct8329ASpdCtrlMode SpdCtrlMode
        {
            get => (Mct8329ASpdCtrlMode)(_value >> SpdCtrlModeLoc & SpdCtrlModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(SpdCtrlModeMask << SpdCtrlModeLoc)) | ((valueUInt32 & SpdCtrlModeMask) << SpdCtrlModeLoc);
            }
        }

        private Mct8329APinConfig1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329APinConfig1(uint value)
        {
            return new Mct8329APinConfig1(value);
        }

        public static implicit operator uint(Mct8329APinConfig1 pinConfig1)
        {
            return pinConfig1._value;
        }
    }
}
