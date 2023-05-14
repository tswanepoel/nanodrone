namespace Biscuits.Devices.AlgorithmConfiguration
{
    using System;

    public struct Mct8329AConstSpeed
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int SpdPowerKpLoc = 20;
        private const uint SpdPowerKpMask = 0x3FF;

        private const int SpdPowerKiLoc = 8;
        private const uint SpdPowerKiMask = 0xFFF;

        private const int SpdPowerVMaxLoc = 5;
        private const uint SpdPowerVMaxMask = 0b111;

        private const int SpdPowerVMinLoc = 2;
        private const uint SpdPowerVMinMask = 0b111;

        private const int ClosedLoopModeLoc = 0;
        private const uint ClosedLoopModeMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public float SpdPowerKp
        {
            get => ((_value >> SpdPowerKpLoc) & SpdPowerKpMask) / 10_000f;
            set
            {
                const float maxValue = SpdPowerKpMask / 10_000f;

                if (value < 0f || value > maxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"SpdPowerKp must be between 0 and {maxValue}.");
                }

                uint valueUInt32 = (uint)(value * 10_000f);
                _value = (_value & ~(SpdPowerKpMask << SpdPowerKpLoc)) | ((valueUInt32 & SpdPowerKpMask) << SpdPowerKpLoc);
            }
        }

        public float SpdPowerKi
        {
            get => ((_value >> SpdPowerKiLoc) & SpdPowerKiMask) / 1_000_000f;
            set
            {
                const float maxValue = SpdPowerKiMask / 1_000_000f;

                if (value < 0f || value > maxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"SpdPowerKi must be between 0 and {maxValue}.");
                }

                uint valueUInt32 = (uint)(value * 1_000_000f);
                _value = (_value & ~(SpdPowerKiMask << SpdPowerKiLoc)) | ((valueUInt32 & SpdPowerKiMask) << SpdPowerKiLoc);
            }
        }

        public Mct8329ASpdPowerVMax SpdPowerVMax
        {
            get => (Mct8329ASpdPowerVMax)(_value >> SpdPowerVMaxLoc & SpdPowerVMaxMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(SpdPowerVMaxMask << SpdPowerVMaxLoc)) | ((valueUInt32 & SpdPowerVMaxMask) << SpdPowerVMaxLoc);
            }
        }

        public Mct8329ASpdPowerVMin SpdPowerVMin
        {
            get => (Mct8329ASpdPowerVMin)(_value >> SpdPowerVMinLoc & SpdPowerVMinMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(SpdPowerVMinMask << SpdPowerVMinLoc)) | ((valueUInt32 & SpdPowerVMinMask) << SpdPowerVMinLoc);
            }
        }

        public Mct8329AClosedLoopMode ClosedLoopMode
        {
            get => (Mct8329AClosedLoopMode)(_value >> ClosedLoopModeLoc & ClosedLoopModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ClosedLoopModeMask << ClosedLoopModeLoc)) | ((valueUInt32 & ClosedLoopModeMask) << ClosedLoopModeLoc);
            }
        }

        private Mct8329AConstSpeed(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AConstSpeed(uint value)
        {
            return new Mct8329AConstSpeed(value);
        }

        public static implicit operator uint(Mct8329AConstSpeed constSpeed)
        {
            return constSpeed._value;
        }
    }
}
