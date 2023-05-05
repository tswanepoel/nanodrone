using System;

namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    public static class Mct8329ADirInputExtensions
    {
        public static string GetDescription(this Mct8329ADirInput dirInput)
            => dirInput switch
            {
                Mct8329ADirInput.HardwarePin => "Hardware pin",
                Mct8329ADirInput.Clockwise => "Clockwise rotation",
                Mct8329ADirInput.CounterClockwise => "Counter-clockwise rotation",
                _ => throw new NotSupportedException()
            };
    }
}
