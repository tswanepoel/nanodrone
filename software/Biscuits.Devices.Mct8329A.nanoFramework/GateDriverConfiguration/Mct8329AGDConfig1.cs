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
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(VRefSelMask << VRefSelLoc)) | ((valueUInt32 & VRefSelMask) << VRefSelLoc);
            }
        }

        public bool DisBstFlt
        {
            get => (_value >> DisBstFltLoc & DisBstFltMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(DisBstFltMask << DisBstFltLoc)) | ((valueUInt32 & DisBstFltMask) << DisBstFltLoc);
            }
        }

        public Mct8329AOtsAutoRecovery OtsAutoRecovery
        {
            get => (Mct8329AOtsAutoRecovery)(_value >> OtsAutoRecoveryLoc & OtsAutoRecoveryMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(OtsAutoRecoveryMask << OtsAutoRecoveryLoc)) | ((valueUInt32 & OtsAutoRecoveryMask) << OtsAutoRecoveryLoc);
            }
        }

        public bool DisSnsFlt
        {
            get => (_value >> DisSnsFltLoc & DisSnsFltMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(DisSnsFltMask << DisSnsFltLoc)) | ((valueUInt32 & DisSnsFltMask) << DisSnsFltLoc);
            }
        }

        public bool DisVdsFlt
        {
            get => (_value >> DisVdsFltLoc & DisVdsFltMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(DisVdsFltMask << DisVdsFltLoc)) | ((valueUInt32 & DisVdsFltMask) << DisVdsFltLoc);
            }
        }

        public Mct8329ASelVdsLvl SelVdsLvl
        {
            get => (Mct8329ASelVdsLvl)(_value >> SelVdsLvlLoc & SelVdsLvlMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(SelVdsLvlMask << SelVdsLvlLoc)) | ((valueUInt32 & SelVdsLvlMask) << SelVdsLvlLoc);
            }
        }

        public Mct8329ACsaGain CsaGain
        {
            get => (Mct8329ACsaGain)(_value >> CsaGainLoc & CsaGainMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CsaGainMask << CsaGainLoc)) | ((valueUInt32 & CsaGainMask) << CsaGainLoc);
            }
        }

        private Mct8329AGDConfig1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AGDConfig1(uint value)
        {
            return new Mct8329AGDConfig1(value);
        }

        public static implicit operator uint(Mct8329AGDConfig1 gdConfig1)
        {
            return gdConfig1._value;
        }
    }
}
