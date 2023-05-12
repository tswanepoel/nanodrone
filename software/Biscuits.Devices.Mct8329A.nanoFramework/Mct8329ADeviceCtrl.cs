namespace Biscuits.Devices
{
    using System;

    /// <summary>
    /// Represents device control registers.
    /// </summary>
    public struct Mct8329ADeviceCtrl
    {
        private const int SpeedCtrlLoc = 16;
        private const uint SpeedCtrlMask = 0x7FFF;

        private const int OverrideLoc = 15;
        private const uint OverrideMask = 0b1;

        private uint _value;

        /// <summary>
        /// Gets or sets the I2C speed command percentage.
        /// </summary>
        public float SpeedCtrl
        {
            get => ((_value >> SpeedCtrlLoc) & SpeedCtrlMask) / 32767f;
            set
            {
                if (value < 0f || value > 1f)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "SpeedCtrl must be between 0 and 1.");
                }

                uint valueUInt32 = (uint)(value * 32767f);
                _value = (_value & ~(SpeedCtrlMask << SpeedCtrlLoc)) | ((valueUInt32 & SpeedCtrlMask) << SpeedCtrlLoc);
            }
        }

        /// <summary>
        /// Gets or sets the value indicating whether <see cref="SpeedCtrl" /> overrides the hardware SPEED pin.
        /// </summary>
        public bool Override
        {
            get => ((_value >> OverrideLoc) & OverrideMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(OverrideMask << OverrideLoc)) | ((valueUInt32 & OverrideMask) << OverrideLoc);
            }
        }

        private Mct8329ADeviceCtrl(uint value)
        {
            _value = value;
        }

        /// <summary>
        /// Converts a raw value to an instance of <see cref="Mct8329ADeviceCtrl" />.
        /// </summary>
        public static explicit operator Mct8329ADeviceCtrl(uint value)
        {
            return new Mct8329ADeviceCtrl(value);
        }

        /// <summary>
        /// Converts an instance of <see cref="Mct8329ADeviceCtrl" /> to a raw value.
        /// </summary>
        public static implicit operator uint(Mct8329ADeviceCtrl deviceCtrl)
        {
            return deviceCtrl._value;
        }
    }
}
