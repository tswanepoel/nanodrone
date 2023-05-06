namespace Biscuits.Devices.HardwareConfiguration
{
    using System;

    public static class Mct8329ASpdPwmRangeSelectExtensions
    {
        public static string GetDescription(this Mct8329ASpdPwmRangeSelect spdPwmRangeSelect)
            => spdPwmRangeSelect switch
            {
                Mct8329ASpdPwmRangeSelect.Speed10HzTo325Hz => "10 Hz to 325 Hz",
                Mct8329ASpdPwmRangeSelect.Speed325HzTo95kHz => "325 Hz to 95 kHz",
                _ => throw new NotSupportedException()
            };
    }
}
