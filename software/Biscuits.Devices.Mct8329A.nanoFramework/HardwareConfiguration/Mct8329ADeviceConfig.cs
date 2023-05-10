namespace Biscuits.Devices.HardwareConfiguration
{
    using System;

    public struct Mct8329ADeviceConfig
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int InputMaxFrequencyLoc = 16;
        private const uint InputMaxFrequencyMask = 0x7FFF;

        private const int StlEnableLoc = 15;
        private const uint StlEnableMask = 0b1;

        private const int SsmConfigLoc = 14;
        private const uint SsmConfigMask = 0b1;

        private const int DevModeLoc = 11;
        private const uint DevModeMask = 0b1;

        private const int SpdPwmRangeSelectLoc = 10;
        private const uint SpdPwmRangeSelectMask = 0b1;

        private const int ClkSelLoc = 8;
        private const uint ClkSelMask = 0b11;

        private const int ExtClkEnLoc = 7;
        private const uint ExtClkEnMask = 0b1;

        private const int ExtClkConfigLoc = 4;
        private const uint ExtClkConfigMask = 0b11;

        private const int DigDeadTimeLoc = 0;
        private const uint DigDeadTimeMask = 0xF;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public int InputMaxFrequency
        {
            get => (int)(_value >> InputMaxFrequencyLoc & InputMaxFrequencyMask);
            set
            {
                if (value < 0 || value > InputMaxFrequencyMask)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"InputMaxFrequency must be between 0 and {InputMaxFrequencyMask}.");
                }

                uint valueUInt32 = (uint)(value);
                _value = (_value & ~(InputMaxFrequencyMask << InputMaxFrequencyLoc)) | ((valueUInt32 & InputMaxFrequencyMask) << InputMaxFrequencyLoc);
            }
        }

        public bool StlEnable
        {
            get => (_value >> StlEnableLoc & StlEnableMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(StlEnableMask << StlEnableLoc)) | ((valueUInt32 & StlEnableMask) << StlEnableLoc);
            }
        }

        public bool SsmConfig
        {
            get => (_value >> SsmConfigLoc & SsmConfigMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(SsmConfigMask << SsmConfigLoc)) | ((valueUInt32 & SsmConfigMask) << SsmConfigLoc);
            }
        }

        public Mct8329ADevMode DevMode
        {
            get => (Mct8329ADevMode)(_value >> DevModeLoc & DevModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DevModeMask << DevModeLoc)) | ((valueUInt32 & DevModeMask) << DevModeLoc);
            }
        }

        public Mct8329ASpdPwmRangeSelect SpdPwmRangeSelect
        {
            get => (Mct8329ASpdPwmRangeSelect)(_value >> SpdPwmRangeSelectLoc & SpdPwmRangeSelectMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(SpdPwmRangeSelectMask << SpdPwmRangeSelectLoc)) | ((valueUInt32 & SpdPwmRangeSelectMask) << SpdPwmRangeSelectLoc);
            }
        }

        public Mct8329AClkSel ClkSel
        {
            get => (Mct8329AClkSel)(_value >> ClkSelLoc & ClkSelMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ClkSelMask << ClkSelLoc)) | ((valueUInt32 & ClkSelMask) << ClkSelLoc);
            }
        }

        public bool ExtClkEn
        {
            get => (_value >> ExtClkEnLoc & ExtClkEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(ExtClkEnMask << ExtClkEnLoc)) | ((valueUInt32 & ExtClkEnMask) << ExtClkEnLoc);
            }
        }

        public Mct8329AExtClkConfig ExtClkConfig
        {
            get => (Mct8329AExtClkConfig)(_value >> ExtClkConfigLoc & ExtClkConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ExtClkConfigMask << ExtClkConfigLoc)) | ((valueUInt32 & ExtClkConfigMask) << ExtClkConfigLoc);
            }
        }

        public Mct8329ADigDeadTime DigDeadTime
        {
            get => (Mct8329ADigDeadTime)(_value >> DigDeadTimeLoc & DigDeadTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DigDeadTimeMask << DigDeadTimeLoc)) | ((valueUInt32 & DigDeadTimeMask) << DigDeadTimeLoc);
            }
        }

        private Mct8329ADeviceConfig(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329ADeviceConfig(uint value)
        {
            return new Mct8329ADeviceConfig(value);
        }

        public static implicit operator uint(Mct8329ADeviceConfig deviceConfig)
        {
            return deviceConfig._value;
        }
    }
}
