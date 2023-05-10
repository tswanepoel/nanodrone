namespace Biscuits.Devices
{
    public struct Mct8329AAlgoCtrl1
    {
        private const int EepromWrtLoc = 31;
        private const uint EepromWrtMask = 0b1;

        private const int EepromReadLoc = 30;
        private const uint EepromReadMask = 0b1;

        private const int ClrFltLoc = 29;
        private const uint ClrFltMask = 0b1;

        private const int ClrFltRetryCountLoc = 28;
        private const uint ClrFltRetryCountMask = 0b1;

        private const int EepromWriteAccessKeyLoc = 20;
        private const uint EepromWriteAccessKeyMask = 0xFF;

        private const int ExtWdStatusSetLoc = 0;
        private const uint ExtWdStatusSetMask = 0b1;

        private uint _value;

        public bool EepromWrt
        {
            get => ((_value >> EepromWrtLoc) & EepromWrtMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(EepromWrtMask << EepromWrtLoc)) | ((valueUInt32 & EepromWrtMask) << EepromWrtLoc);
            }
        }

        public bool EepromRead
        {
            get => ((_value >> EepromReadLoc) & EepromReadMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(EepromReadMask << EepromReadLoc)) | ((valueUInt32 & EepromReadMask) << EepromReadLoc);
            }
        }

        public bool ClrFlt
        {
            get => ((_value >> ClrFltLoc) & ClrFltMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(ClrFltMask << ClrFltLoc)) | ((valueUInt32 & ClrFltMask) << ClrFltLoc);
            }
        }

        public bool ClrFltRetryCount
        {
            get => ((_value >> ClrFltRetryCountLoc) & ClrFltRetryCountMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(ClrFltRetryCountMask << ClrFltRetryCountLoc)) | ((valueUInt32 & ClrFltRetryCountMask) << ClrFltRetryCountLoc);
            }
        }

        public int EepromWriteAccessKey
        {
            get => (int)((_value >> EepromWriteAccessKeyLoc) & EepromWriteAccessKeyMask);
            set
            {
                uint valueUInt32 = (uint)value;
                _value = (_value & ~(EepromWriteAccessKeyMask << EepromWriteAccessKeyLoc)) | ((valueUInt32 & EepromWriteAccessKeyMask) << EepromWriteAccessKeyLoc);
            }
        }

        public bool ExtWdStatusSet
        {
            get => ((_value >> ExtWdStatusSetLoc) & ExtWdStatusSetMask) != 0;
            set
            {
                uint valueUInt32 = (uint)(value ? 0b1 : 0b0);
                _value = (_value & ~(ExtWdStatusSetMask << ExtWdStatusSetLoc)) | ((valueUInt32 & ExtWdStatusSetMask) << ExtWdStatusSetLoc);
            }
        }

        private Mct8329AAlgoCtrl1(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329AAlgoCtrl1(uint value)
        {
            return new Mct8329AAlgoCtrl1(value);
        }

        public static implicit operator uint(Mct8329AAlgoCtrl1 algoCtrl1)
        {
            return algoCtrl1._value;
        }
    }
}
