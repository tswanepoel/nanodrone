namespace Biscuits.Devices
{
    public readonly struct Mct8329ASysStatus1
    {
        private const int VoltMagLoc = 16;
        private const uint VoltMagMask = 0xFFFF;

        private const int SpeedCmdLoc = 1;
        private const uint SpeedCmdMask = 0x7FFF;

        private const int I2cEntryStatusLoc = 0;
        private const uint I2cEntryStatusMask = 0b1;

        private readonly uint _value;

        public float VoltMag
        {
            get => ((_value >> VoltMagLoc) & VoltMagMask) / 10f;
        }

        public float SpeedCmd
        {
            get => ((_value >> SpeedCmdLoc) & SpeedCmdMask) / 10f;
        }

        public bool I2cEntryStatus
        {
            get => ((_value >> I2cEntryStatusLoc) & I2cEntryStatusMask) != 0;
        }

        private Mct8329ASysStatus1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329ASysStatus1(uint value)
        {
            return new Mct8329ASysStatus1(value);
        }

        public static implicit operator uint(Mct8329ASysStatus1 config)
        {
            return config._value;
        }
    }
}
