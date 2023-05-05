namespace Biscuits.Devices
{
    public readonly struct Mct8329ASysStatus3
    {
        private const int DcBusCurrLoc = 16;
        private const uint DcBusCurrMask = 0xFFFF;

        private const int DcBattPowLoc = 0;
        private const uint DcBattPowMask = 0xFFFF;

        private readonly uint _value;

        public float DcBusCurr 
        {
            get => ((_value >> DcBusCurrLoc) & DcBusCurrMask) / 256f; 
        }

        public float DcBattPow 
        {
            get => ((_value >> DcBattPowLoc) & DcBattPowMask) / 64f;
        }

        private Mct8329ASysStatus3(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329ASysStatus3(uint value)
        {
            return new Mct8329ASysStatus3(value);
        }

        public static implicit operator uint(Mct8329ASysStatus3 config)
        {
            return config._value;
        }
    }
}
