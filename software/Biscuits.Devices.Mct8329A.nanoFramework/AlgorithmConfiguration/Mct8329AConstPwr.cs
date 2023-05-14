namespace Biscuits.Devices.AlgorithmConfiguration
{
    using System;

    public struct Mct8329AConstPwr
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int MaxSpeedLoc = 15;
        private const uint MaxSpeedMask = 0xFFFF;

        private const int MaxPowerLoc = 4;
        private const uint MaxPowerMask = 0x7FF;

        private const int ConstPowerLimitHystLoc = 2;
        private const uint ConstPowerLimitHystMask = 0b11;

        private const int ConstPowerModeLoc = 0;
        private const uint ConstPowerModeMask = 0b11;

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
                const float maxValue = 3_000f;

                if (value < 0f || value > maxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"MaxSpeed must be between 0 and {maxValue}.");
                }
                
                uint valueUInt32 = (uint)(value * 16f);
                _value = (_value & ~(MaxSpeedMask << MaxSpeedLoc)) | ((valueUInt32 & MaxSpeedMask) << MaxSpeedLoc);
            }
        }

        public int MaxPower
        {
            get => (int)((_value >> MaxPowerLoc) & MaxPowerMask);
            set
            {
                if (value < 0f || value > MaxPowerMask)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"MaxSpeed must be between 0 and {MaxPowerMask}.");
                }

                uint valueUInt32 = (uint)(value);
                _value = (_value & ~(MaxPowerMask << MaxPowerLoc)) | ((valueUInt32 & MaxPowerMask) << MaxPowerLoc);
            }
        }

        public Mct8329AConstPowerLimitHyst ConstPowerLimitHyst
        {
            get => (Mct8329AConstPowerLimitHyst)(_value >> ConstPowerLimitHystLoc & ConstPowerLimitHystMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ConstPowerLimitHystMask << ConstPowerLimitHystLoc)) | ((valueUInt32 & ConstPowerLimitHystMask) << ConstPowerLimitHystLoc);
            }
        }

        public Mct8329AConstPowerMode ConstPowerMode
        {
            get => (Mct8329AConstPowerMode)(_value >> ConstPowerModeLoc & ConstPowerModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ConstPowerModeMask << ConstPowerModeLoc)) | ((valueUInt32 & ConstPowerModeMask) << ConstPowerModeLoc);
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
