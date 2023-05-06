using Biscuits.Devices.HardwareConfiguration.Extensions;

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

        private readonly uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ADacoutVarAddr DacoutVarAddr
        {
            get => (Mct8329ADacoutVarAddr)(_value >> DacoutVarAddrLoc & DacoutVarAddrMask);
        }

        public Mct8329ABrakeInput BrakeInput
        {
            get => (Mct8329ABrakeInput)(_value >> BrakeInputLoc & BrakeInputMask);
        }

        public Mct8329ADirInput DirInput
        {
            get => (Mct8329ADirInput)(_value >> DirInputLoc & DirInputMask);
        }

        public Mct8329ASpdCtrlMode SpdCtrlMode
        {
            get => (Mct8329ASpdCtrlMode)(_value >> SpdCtrlModeLoc & SpdCtrlModeMask);
        }

        private Mct8329APinConfig1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329APinConfig1(uint value)
        {
            return new Mct8329APinConfig1(value);
        }

        public static implicit operator uint(Mct8329APinConfig1 config)
        {
            return config._value;
        }
    }
}
