namespace Biscuits.Devices.AlgorithmConfiguration
{
    public struct Mct8329AIsdConfig
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int IsdEnLoc = 30;
        private const uint IsdEnMask = 0b1;

        private const int BrakeEnLoc = 29;
        private const uint BrakeEnMask = 0b1;

        private const int HiZEnLoc = 28;
        private const uint HiZEnMask = 0b1;

        private const int RvsDrEnLoc = 27;
        private const uint RvsDrEnMask = 0b1;

        private const int ResyncEnLoc = 26;
        private const uint ResyncEnMask = 0b1;

        private const int StatBrkEnLoc = 25;
        private const uint StatBrkEnMask = 0b1;

        private const int StatDetectThrLoc = 22;
        private const uint StatDetectThrMask = 0b111;

        private const int BrkModeLoc = 21;
        private const uint BrkModeMask = 0b1;

        private const int BrkTimeLoc = 13;
        private const uint BrkTimeMask = 0xF;

        private const int HiZTimeLoc = 9;
        private const uint HiZTimeMask = 0xF;

        private const int StartupBrkTimeLoc = 6;
        private const uint StartupBrkTimeMask = 0b111;

        private const int ResyncMinThresholdLoc = 3;
        private const uint ResyncMinThresholdMask = 0b111;

        private const int MtrStartupLoc = 1;
        private const uint MtrStartupMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public bool IsdEn
        {
            get => (_value >> IsdEnLoc & IsdEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(IsdEnMask << IsdEnLoc)) | ((valueUInt32 & IsdEnMask) << IsdEnLoc);
            }
        }

        public bool BrakeEn
        {
            get => (_value >> BrakeEnLoc & BrakeEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(BrakeEnMask << BrakeEnLoc)) | ((valueUInt32 & BrakeEnMask) << BrakeEnLoc);
            }
        }

        public bool HiZEn
        {
            get => (_value >> HiZEnLoc & HiZEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(HiZEnMask << HiZEnLoc)) | ((valueUInt32 & HiZEnMask) << HiZEnLoc);
            }
        }

        public bool RvsDrEn
        {
            get => (_value >> RvsDrEnLoc & RvsDrEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(RvsDrEnMask << RvsDrEnLoc)) | ((valueUInt32 & RvsDrEnMask) << RvsDrEnLoc);
            }
        }

        public bool ResyncEn
        {
            get => (_value >> ResyncEnLoc & ResyncEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(ResyncEnMask << ResyncEnLoc)) | ((valueUInt32 & ResyncEnMask) << ResyncEnLoc);
            }
        }

        public bool StatBrkEn
        {
            get => (_value >> StatBrkEnLoc & StatBrkEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(StatBrkEnMask << StatBrkEnLoc)) | ((valueUInt32 & StatBrkEnMask) << StatBrkEnLoc);
            }
        }

        public Mct8329AStatDetectThr StatDetectThr
        {
            get => (Mct8329AStatDetectThr)(_value >> StatDetectThrLoc & StatDetectThrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(StatDetectThrMask << StatDetectThrLoc)) | ((valueUInt32 & StatDetectThrMask) << StatDetectThrLoc);
            }
        }

        public Mct8329ABrkMode BrkMode
        {
            get => (Mct8329ABrkMode)(_value >> BrkModeLoc & BrkModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(BrkModeMask << BrkModeLoc)) | ((valueUInt32 & BrkModeMask) << BrkModeLoc);
            }
        }

        public Mct8329ABrkTime BrkTime
        {
            get => (Mct8329ABrkTime)(_value >> BrkTimeLoc & BrkTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(BrkTimeMask << BrkTimeLoc)) | ((valueUInt32 & BrkTimeMask) << BrkTimeLoc);
            }
        }

        public Mct8329AHiZTime HiZTime
        {
            get => (Mct8329AHiZTime)(_value >> HiZTimeLoc & HiZTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(HiZTimeMask << HiZTimeLoc)) | ((valueUInt32 & HiZTimeMask) << HiZTimeLoc);
            }
        }

        public Mct8329AStartupBrkTime StartupBrkTime
        {
            get => (Mct8329AStartupBrkTime)(_value >> StartupBrkTimeLoc & StartupBrkTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(StartupBrkTimeMask << StartupBrkTimeLoc)) | ((valueUInt32 & StartupBrkTimeMask) << StartupBrkTimeLoc);
            }
        }

        public Mct8329AResyncMinThreshold ResyncMinThreshold
        {
            get => (Mct8329AResyncMinThreshold)(_value >> ResyncMinThresholdLoc & ResyncMinThresholdMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ResyncMinThresholdMask << ResyncMinThresholdLoc)) | ((valueUInt32 & ResyncMinThresholdMask) << ResyncMinThresholdLoc);
            }
        }

        public Mct8329AMtrStartup MtrStartup
        {
            get => (Mct8329AMtrStartup)(_value >> MtrStartupLoc & MtrStartupMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MtrStartupMask << MtrStartupLoc)) | ((valueUInt32 & MtrStartupMask) << MtrStartupLoc);
            }
        }

        private Mct8329AIsdConfig(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AIsdConfig(uint value)
        {
            return new Mct8329AIsdConfig(value);
        }

        public static implicit operator uint(Mct8329AIsdConfig isdConfig)
        {
            return isdConfig._value;
        }
    }
}
