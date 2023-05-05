namespace Biscuits.Devices.HardwareConfiguration
{
    public struct Mct8329APinConfig2
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int DacSoxAnaConfigLoc = 29;
        private const uint DacSoxAnaConfigMask = 0b11;

        private const int SleepTimeLoc = 27;
        private const uint SleepTimeMask = 0b11;

        private const int I2cTargetAddrLoc = 20;
        private const uint I2cTargetAddrMask = 0x3F;

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

        public bool ParityBit
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ADacSoxAnaConfig DacSoxAnaConfig
        {
            get => (Mct8329ADacSoxAnaConfig)(_value >> DacSoxAnaConfigLoc & DacSoxAnaConfigMask);
        }

        public Mct8329ASleepTime SleepTime
        {
            get => (Mct8329ASleepTime)(_value >> SleepTimeLoc & SleepTimeMask);
        }

        public int I2cTargetAddr
        {
            get => (int)(_value >> I2cTargetAddrLoc & I2cTargetAddrMask);
        }

        public Mct8329AFGConfig FgConfig
        {
            get => (Mct8329AFGConfig)(_value >> FGConfigLoc & FGConfigMask);
        }

        public Mct8329AFGPinConfig FgPinFaultConfig
        {
            get => (Mct8329AFGPinConfig)(_value >> FGPinFaultConfigLoc & FGPinFaultConfigMask);
        }

        public Mct8329AFGPinConfig FgPinStopConfig
        {
            get => (Mct8329AFGPinConfig)(_value >> FGPinStopConfigLoc & FGPinStopConfigMask);
        }

        public Mct8329ATBlank TBlank
        {
            get => (Mct8329ATBlank)(_value >> TBlankLoc & TBlankMask);
        }

        public Mct8329ATPWdth TPWdth
        {
            get => (Mct8329ATPWdth)(_value >> TPWdthLoc & TPWdthMask);
        }

        public Mct8329AZeroDutyHyst ZeroDutyHyst
        {
            get => (Mct8329AZeroDutyHyst)(_value >> ZeroDutyHystLoc & ZeroDutyHystMask);
        }

        private Mct8329APinConfig2(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329APinConfig2(uint value)
        {
            return new Mct8329APinConfig2(value);
        }

        public static implicit operator uint(Mct8329APinConfig2 config)
        {
            return config._value;
        }
    }
}
