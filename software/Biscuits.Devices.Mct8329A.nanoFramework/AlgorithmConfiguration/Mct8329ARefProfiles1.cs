namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329ARefProfiles1
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int RefProfileConfigLoc = 29;
        private const uint RefProfileConfigMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ARefProfileConfig RefProfileConfig
        {
            get => (Mct8329ARefProfileConfig)(_value >> RefProfileConfigLoc & RefProfileConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(RefProfileConfigMask << RefProfileConfigLoc)) | ((valueUInt32 & RefProfileConfigMask) << RefProfileConfigLoc);
            }
        }

        private Mct8329ARefProfiles1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329ARefProfiles1(uint value)
        {
            return new Mct8329ARefProfiles1(value);
        }

        public static implicit operator uint(Mct8329ARefProfiles1 refProfiles1)
        {
            return refProfiles1._value;
        }
    }
}
