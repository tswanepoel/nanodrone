using System;

namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    public static class Mct8329ASleepTimeExtensions
    {
        public static string GetDescription(this Mct8329ASleepTime sleepTime)
            => sleepTime switch
            {
                Mct8329ASleepTime.CheckLowFor50us => "Check low for 50 µs",
                Mct8329ASleepTime.CheckLowFor200us => "Check low for 200 µs",
                Mct8329ASleepTime.CheckLowFor20ms => "Check low for 20 ms",
                Mct8329ASleepTime.CheckLowFor200ms => "Check low for 500 ms",
                _ => throw new NotSupportedException()
            };
    }
}
