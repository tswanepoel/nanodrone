namespace Biscuits.Devices
{
    public struct Mct8329ADeviceCtrl
    {
        private const int SpeedCtrlLoc = 0;
        private const uint SpeedCtrlMask = 0xFFFF;

        private const int OverrideLoc = 31;
        private const uint OverrideMask = 0b1;

        private readonly uint _value;

        public float SpeedCtrl
        {
            get => ((_value >> SpeedCtrlLoc) & SpeedCtrlMask) / 32767f;
        }

        public bool Override
        {
            get => ((_value >> OverrideLoc) & OverrideMask) != 0; 
        }

        private Mct8329ADeviceCtrl(uint value)
        {
            _value = value;
        }

        public static explicit operator Mct8329ADeviceCtrl(uint value)
        {
            return new Mct8329ADeviceCtrl(value);
        }

        public static implicit operator uint(Mct8329ADeviceCtrl config)
        {
            return config._value;
        }
    }
}
