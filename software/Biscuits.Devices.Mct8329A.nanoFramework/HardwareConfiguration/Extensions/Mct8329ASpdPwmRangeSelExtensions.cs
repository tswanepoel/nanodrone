namespace Biscuits.Devices.HardwareConfiguration
{
    public static class Mct8329ASpdPwmRangeSelExtensions
    {
        public static string GetDescription(this Mct8329ASpdPwmRangeSel spdPwmRangeSel)
            => spdPwmRangeSel switch
            {
                Mct8329ASpdPwmRangeSel.Speed10HzTo325Hz => "10 Hz to 325 Hz",
                Mct8329ASpdPwmRangeSel.Speed325HzTo95kHz => "325 Hz to 95 kHz",
                _ => throw new NotSupportedException()
            };
    }
}
