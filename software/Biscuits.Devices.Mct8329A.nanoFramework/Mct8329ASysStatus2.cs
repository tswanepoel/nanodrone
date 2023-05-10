namespace Biscuits.Devices
{
    public readonly struct Mct8329ASysStatus2
    {
        private const int StateLoc = 28;
        private const uint StateMask = 0xF;

        private const int StlFaultLoc = 17;
        private const uint StlFaultMask = 0b1;

        private const int MotorSpeedLoc = 0;
        private const uint MotorSpeedMask = 0xFFFF;

        private readonly uint _value;

        public Mct8329AState State
        {
            get => (Mct8329AState)((_value >> StateLoc) & StateMask);
        }

        public bool StlFault 
        {
            get => ((_value >> StlFaultLoc) & StlFaultMask) != 0;
        }

        public float MotorSpeed 
        {
            get => ((_value >> MotorSpeedLoc) & MotorSpeedMask) / 10f;
        }

        private Mct8329ASysStatus2(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329ASysStatus2(uint value)
        {
            return new Mct8329ASysStatus2(value);
        }

        public static implicit operator uint(Mct8329ASysStatus2 sysStatus2)
        {
            return sysStatus2._value;
        }
    }
}
