namespace Biscuits.Devices.AlgorithmConfiguration
{
    using System;

    public struct Mct8329AConstPwr
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int MaxSpeedLoc = 15;
        private const uint MaxSpeedMask = 0xFFFF;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public float MaxSpeed
        {
            get => ((_value >> MaxSpeedLoc) & MaxSpeedMask) / 16f;
            set
            {
                const float maxValue = MaxSpeedMask / 16f;

                if (value < 0f || value > maxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"MaxSpeed must be between 0 and {maxValue}.");
                }
                
                uint valueUInt32 = (uint)(value * 16f);
                _value = (_value & ~(MaxSpeedMask << MaxSpeedLoc)) | ((valueUInt32 & MaxSpeedMask) << MaxSpeedLoc);
            }
        }

        private Mct8329AConstPwr(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AConstPwr(uint value)
        {
            return new Mct8329AConstPwr(value);
        }

        public static implicit operator uint(Mct8329AConstPwr constPwr)
        {
            return constPwr._value;
        }
    }
}
