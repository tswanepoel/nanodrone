namespace Biscuits.Devices.FaultConfiguration
{
    using System;

    public struct Mct8329AFaultConfig1
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int NoMtrDegTimeLoc = 28;
        private const uint NoMtrDegTimeMask = 0b111;

        private const int CbcILimitModeLoc = 24;
        private const uint CbcILimitModeMask = 0xF;

        private const int LockILimitLoc = 19;
        private const uint LockILimitMask = 0x1F;

        private const int LockILimitModeLoc = 15;
        private const uint LockILimitModeMask = 0xF;

        private const int LockILimitDegLoc = 11;
        private const uint LockILimitDegMask = 0xF;

        private const int CbcRetryPwmCycLoc = 8;
        private const uint CbcRetryPwmCycMask = 0b111;

        private const int MtrLckModeLoc = 3;
        private const uint MtrLckModeMask = 0xF;

        private const int LckRetryLoc = 0;
        private const uint LckRetryMask = 0b111;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public Mct8329ANoMtrDegTime NoMtrDegTime
        {
            get => (Mct8329ANoMtrDegTime)(_value >> NoMtrDegTimeLoc & NoMtrDegTimeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(NoMtrDegTimeMask << NoMtrDegTimeLoc)) | ((valueUInt32 & NoMtrDegTimeMask) << NoMtrDegTimeLoc);
            }
        }
        
        public Mct8329ACbcILimitMode CbcILimitMode
        {
            get => (Mct8329ACbcILimitMode)(_value >> CbcILimitModeLoc & CbcILimitModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CbcILimitModeMask << CbcILimitModeLoc)) | ((valueUInt32 & CbcILimitModeMask) << CbcILimitModeLoc);
            }
        }

        public Mct8329ALockILimit LockILimit
        {
            get => (Mct8329ALockILimit)(_value >> LockILimitLoc & LockILimitMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LockILimitMask << LockILimitLoc)) | ((valueUInt32 & LockILimitMask) << LockILimitLoc);
            }
        }

        public Mct8329ALockILimitMode LockILimitMode
        {
            get => (Mct8329ALockILimitMode)(_value >> LockILimitModeLoc & LockILimitModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LockILimitModeMask << LockILimitModeLoc)) | ((valueUInt32 & LockILimitModeMask) << LockILimitModeLoc);
            }
        }

        public Mct8329ALockILimitDeg LockILimitDeg
        {
            get => (Mct8329ALockILimitDeg)(_value >> LockILimitDegLoc & LockILimitDegMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LockILimitDegMask << LockILimitDegLoc)) | ((valueUInt32 & LockILimitDegMask) << LockILimitDegLoc);
            }
        }

        public int CbcRetryPwmCyc
        {
            get => (int)(_value >> CbcRetryPwmCycLoc & CbcRetryPwmCycMask);
            set
            {
                if (value < 0f || value > CbcRetryPwmCycMask)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"SpeedCtrl must be between 0 and {CbcRetryPwmCycMask}.");
                }

                uint valueUInt32 = (uint)value;
                _value = (_value & ~(CbcRetryPwmCycMask << CbcRetryPwmCycLoc)) | ((valueUInt32 & CbcRetryPwmCycMask) << CbcRetryPwmCycLoc);
            }
        }

        public Mct8329AMtrLckMode MtrLckMode
        {
            get => (Mct8329AMtrLckMode)(_value >> MtrLckModeLoc & MtrLckModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MtrLckModeMask << MtrLckModeLoc)) | ((valueUInt32 & MtrLckModeMask) << MtrLckModeLoc);
            }
        }

        public Mct8329ALckRetry LckRetry
        {
            get => (Mct8329ALckRetry)(_value >> LckRetryLoc & LckRetryMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LckRetryMask << LckRetryLoc)) | ((valueUInt32 & LckRetryMask) << LckRetryLoc);
            }
        }

        private Mct8329AFaultConfig1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AFaultConfig1(uint value)
        {
            return new Mct8329AFaultConfig1(value);
        }

        public static implicit operator uint(Mct8329AFaultConfig1 faultConfig1)
        {
            return faultConfig1._value;
        }
    }
}
