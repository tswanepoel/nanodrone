namespace Biscuits.Devices.HardwareConfiguration
{
    using System;

    public struct Mct8329APinConfig2
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int DacSoxAnaConfigLoc = 29;
        private const uint DacSoxAnaConfigMask = 0b11;

        private const int SleepTimeLoc = 27;
        private const uint SleepTimeMask = 0b11;

        private const int I2cTargetAddrLoc = 20;
        private const uint I2cTargetAddrMask = 0x7F;

        private const int FGConfigLoc = 13;
        private const uint FGConfigMask = 0b1;

        private const int FGPinFaultConfigLoc = 11;
        private const uint FGPinFaultConfigMask = 0b11;

        private const int FGPinStopConfigLoc = 9;
        private const uint FGPinStopConfigMask = 0b11;

        private const int TBlankLoc = 5;
        private const uint TBlankMask = 0xF;

        private const int TPWdthLoc = 2;
        private const uint TPWdthMask = 0b111;

        private const int ZeroDutyHystLoc = 0;
        private const uint ZeroDutyHystMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ADacSoxAnaConfig DacSoxAnaConfig
        {
            get => (Mct8329ADacSoxAnaConfig)(_value >> DacSoxAnaConfigLoc & DacSoxAnaConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(DacSoxAnaConfigMask << DacSoxAnaConfigLoc)) | ((valueUInt32 & DacSoxAnaConfigMask) << DacSoxAnaConfigLoc);
            }
        }

        public Mct8329ASleepTime SleepTime
        {
            get => (Mct8329ASleepTime)(_value >> SleepTimeLoc & SleepTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(SleepTimeMask << SleepTimeLoc)) | ((valueUInt32 & SleepTimeMask) << SleepTimeLoc);
            }
        }

        public int I2cTargetAddr
        {
            get => (int)(_value >> I2cTargetAddrLoc & I2cTargetAddrMask);
            set
            {
                if (value < 0 || value > I2cTargetAddrMask)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"I2cTargetAddr must be between 0 and {I2cTargetAddrMask}.");
                }

                uint valueUInt32 = (uint)(value);
                _value = (_value & ~(I2cTargetAddrMask << I2cTargetAddrLoc)) | ((valueUInt32 & I2cTargetAddrMask) << I2cTargetAddrLoc);
            }
        }

        public Mct8329AFGConfig FgConfig
        {
            get => (Mct8329AFGConfig)(_value >> FGConfigLoc & FGConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FGConfigMask << FGConfigLoc)) | ((valueUInt32 & FGConfigMask) << FGConfigLoc);
            }
        }

        public Mct8329AFGPinConfig FgPinFaultConfig
        {
            get => (Mct8329AFGPinConfig)(_value >> FGPinFaultConfigLoc & FGPinFaultConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FGPinFaultConfigMask << FGPinFaultConfigLoc)) | ((valueUInt32 & FGPinFaultConfigMask) << FGPinFaultConfigLoc);
            }
        }

        public Mct8329AFGPinConfig FgPinStopConfig
        {
            get => (Mct8329AFGPinConfig)(_value >> FGPinStopConfigLoc & FGPinStopConfigMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(FGPinStopConfigMask << FGPinStopConfigLoc)) | ((valueUInt32 & FGPinStopConfigMask) << FGPinStopConfigLoc);
            }
        }

        public Mct8329ATBlank TBlank
        {
            get => (Mct8329ATBlank)(_value >> TBlankLoc & TBlankMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(TBlankMask << TBlankLoc)) | ((valueUInt32 & TBlankMask) << TBlankLoc);
            }
        }

        public Mct8329ATPWdth TPWdth
        {
            get => (Mct8329ATPWdth)(_value >> TPWdthLoc & TPWdthMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(TPWdthMask << TPWdthLoc)) | ((valueUInt32 & TPWdthMask) << TPWdthLoc);
            }
        }

        public Mct8329AZeroDutyHyst ZeroDutyHyst
        {
            get => (Mct8329AZeroDutyHyst)(_value >> ZeroDutyHystLoc & ZeroDutyHystMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ZeroDutyHystMask << ZeroDutyHystLoc)) | ((valueUInt32 & ZeroDutyHystMask) << ZeroDutyHystLoc);
            }
        }

        private Mct8329APinConfig2(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329APinConfig2(uint value)
        {
            return new Mct8329APinConfig2(value);
        }

        public static implicit operator uint(Mct8329APinConfig2 pinConfig2)
        {
            return pinConfig2._value;
        }
    }
}
