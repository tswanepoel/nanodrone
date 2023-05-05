namespace Biscuits.Devices.GateDriverConfiguration
{
    public struct Mct8329AGDConfig1
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int VRefSelLoc = 18;
        private const uint VRefSelMask = 0b1;

        private const int DisBstFltLoc = 16;
        private const uint DisBstFltMask = 0b1;

        private const int OtsAutoRecoveryLoc = 15;
        private const uint OtsAutoRecoveryMask = 0b1;

        private const int DisSnsFltLoc = 9;
        private const uint DisSnsFltMask = 0b1;

        private const int DisVdsFltLoc = 8;
        private const uint DisVdsFltMask = 0b1;

        private const int SelVdsLvlLoc = 3;
        private const uint SelVdsLvlMask = 0xF;

        private const int CsaGainLoc = 0;
        private const uint CsaGainMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329AVRefSel VRefSel
        {
            get => (Mct8329AVRefSel)(_value >> VRefSelLoc & VRefSelMask);
        }

        public bool DisBstFlt
        {
            get => (_value >> DisBstFltLoc & DisBstFltMask) != 0;
        }

        public Mct8329AOtsAutoRecovery OtsAutoRecovery
        {
            get => (Mct8329AOtsAutoRecovery)(_value >> OtsAutoRecoveryLoc & OtsAutoRecoveryMask);
        }

        public bool DisSnsFlt
        {
            get => (_value >> DisSnsFltLoc & DisSnsFltMask) != 0;
        }

        public bool DisVdsFlt
        {
            get => (_value >> DisVdsFltLoc & DisVdsFltMask) != 0;
        }

        public Mct8329ASelVdsLvl SelVdsLvl
        {
            get => (Mct8329ASelVdsLvl)(_value >> SelVdsLvlLoc & SelVdsLvlMask);
        }

        public Mct8329ACsaGain CsaGain
        {
            get => (Mct8329ACsaGain)(_value >> CsaGainLoc & CsaGainMask);
        }

        private Mct8329AGDConfig1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AGDConfig1(uint value)
        {
            return new Mct8329AGDConfig1(value);
        }

        public static implicit operator uint(Mct8329AGDConfig1 config)
        {
            return config._value;
        }
    }
}
