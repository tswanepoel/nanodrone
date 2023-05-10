namespace Biscuits.Devices.FaultConfiguration
{
    public struct Mct8329AFaultConfig2
    {
        private const int ParityLoc = 31;
        private const uint ParityMask = 0b1;

        private const int AbnSpdEnLoc = 30;
        private const uint AbnSpdEnMask = 0b1;

        private const int LossOfSyncEnLoc = 29;
        private const uint LossOfSyncEnMask = 0b1;

        private const int NoMotorEnLoc = 28;
        private const uint NoMotorEnMask = 0b1;

        private const int LockAbnSpeedLoc = 24;
        private const uint LockAbnSpeedMask = 0xF;

        private const int LossSyncTimesLoc = 21;
        private const uint LossSyncTimesMask = 0b111;

        private const int NoMtrThrLoc = 18;
        private const uint NoMtrThrMask = 0b111;

        private const int MaxVMModeLoc = 17;
        private const uint MaxVMModeMask = 0b1;

        private const int MaxVMMotorLoc = 14;
        private const uint MaxVMMotorMask = 0b111;

        private const int MinVMModeLoc = 13;
        private const uint MinVMModeMask = 0b1;

        private const int MinVMMotorLoc = 10;
        private const uint MinVMMotorMask = 0b111;

        private const int AutoRetryTimesLoc = 7;
        private const uint AutoRetryTimesMask = 0b111;

        private const int LockMinSpeedLoc = 4;
        private const uint LockMinSpeedMask = 0b111;

        private const int AbnLockSpdRatioLoc = 2;
        private const uint AbnLockSpdRatioMask = 0b11;

        private const int ZeroDutyThrLoc = 0;
        private const uint ZeroDutyThrMask = 0b11;

        private uint _value;

        public bool Parity
        {
            get => (_value >> ParityLoc & ParityMask) != 0;
        }

        public bool AbnSpdEn
        {
            get => (_value >> AbnSpdEnLoc & AbnSpdEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(AbnSpdEnMask << AbnSpdEnLoc)) | ((valueUInt32 & AbnSpdEnMask) << AbnSpdEnLoc);
            }
        }

        public bool LossOfSyncEn
        {
            get => (_value >> LossOfSyncEnLoc & LossOfSyncEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(LossOfSyncEnMask << LossOfSyncEnLoc)) | ((valueUInt32 & LossOfSyncEnMask) << LossOfSyncEnLoc);
            }
        }

        public bool NoMotorEn
        {
            get => (_value >> NoMotorEnLoc & NoMotorEnMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(NoMotorEnMask << NoMotorEnLoc)) | ((valueUInt32 & NoMotorEnMask) << NoMotorEnLoc);
            }
        }

        public Mct8329ALockAbnSpeed LockAbnSpeed
        {
            get => (Mct8329ALockAbnSpeed)(_value >> LockAbnSpeedLoc & LockAbnSpeedMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LockAbnSpeedMask << LockAbnSpeedLoc)) | ((valueUInt32 & LockAbnSpeedMask) << LockAbnSpeedLoc);
            }
        }

        public Mct8329ALossSyncTimes LossSyncTimes
        {
            get => (Mct8329ALossSyncTimes)(_value >> LossSyncTimesLoc & LossSyncTimesMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LossSyncTimesMask << LossSyncTimesLoc)) | ((valueUInt32 & LossSyncTimesMask) << LossSyncTimesLoc);
            }
        }

        public Mct8329ANoMtrThr NoMtrThr
        {
            get => (Mct8329ANoMtrThr)(_value >> NoMtrThrLoc & NoMtrThrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(NoMtrThrMask << NoMtrThrLoc)) | ((valueUInt32 & NoMtrThrMask) << NoMtrThrLoc);
            }
        }

        public Mct8329AMaxVMMode MaxVMMode
        {
            get => (Mct8329AMaxVMMode)(_value >> MaxVMModeLoc & MaxVMModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MaxVMModeMask << MaxVMModeLoc)) | ((valueUInt32 & MaxVMModeMask) << MaxVMModeLoc);
            }
        }

        public Mct8329AMaxVMMotor MaxVMMotor
        {
            get => (Mct8329AMaxVMMotor)(_value >> MaxVMMotorLoc & MaxVMMotorMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MaxVMMotorMask << MaxVMMotorLoc)) | ((valueUInt32 & MaxVMMotorMask) << MaxVMMotorLoc);
            }
        }

        public Mct8329AMinVMMode MinVMMode
        {
            get => (Mct8329AMinVMMode)(_value >> MinVMModeLoc & MinVMModeMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MinVMModeMask << MinVMModeLoc)) | ((valueUInt32 & MinVMModeMask) << MinVMModeLoc);
            }
        }

        public Mct8329AMinVMMotor MinVMMotor
        {
            get => (Mct8329AMinVMMotor)(_value >> MinVMMotorLoc & MinVMMotorMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(MinVMMotorMask << MinVMMotorLoc)) | ((valueUInt32 & MinVMMotorMask) << MinVMMotorLoc);
            }
        }

        public Mct8329AAutoRetryTimes AutoRetryTimes
        {
            get => (Mct8329AAutoRetryTimes)(_value >> AutoRetryTimesLoc & AutoRetryTimesMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(AutoRetryTimesMask << AutoRetryTimesLoc)) | ((valueUInt32 & AutoRetryTimesMask) << AutoRetryTimesLoc);
            }
        }

        public Mct8329ALockMinSpeed LockMinSpeed
        {
            get => (Mct8329ALockMinSpeed)(_value >> LockMinSpeedLoc & LockMinSpeedMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(LockMinSpeedMask << LockMinSpeedLoc)) | ((valueUInt32 & LockMinSpeedMask) << LockMinSpeedLoc);
            }
        }

        public Mct8329AAbnLockSpdRatio AbnLockSpdRatio
        {
            get => (Mct8329AAbnLockSpdRatio)(_value >> AbnLockSpdRatioLoc & AbnLockSpdRatioMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(AbnLockSpdRatioMask << AbnLockSpdRatioLoc)) | ((valueUInt32 & AbnLockSpdRatioMask) << AbnLockSpdRatioLoc);
            }
        }

        public Mct8329AZeroDutyThr ZeroDutyThr
        {
            get => (Mct8329AZeroDutyThr)(_value >> ZeroDutyThrLoc & ZeroDutyThrMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(ZeroDutyThrMask << ZeroDutyThrLoc)) | ((valueUInt32 & ZeroDutyThrMask) << ZeroDutyThrLoc);
            }
        }

        private Mct8329AFaultConfig2(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AFaultConfig2(uint value)
        {
            return new Mct8329AFaultConfig2(value);
        }

        public static implicit operator uint(Mct8329AFaultConfig2 faultConfig2)
        {
            return faultConfig2._value;
        }
    }
}
