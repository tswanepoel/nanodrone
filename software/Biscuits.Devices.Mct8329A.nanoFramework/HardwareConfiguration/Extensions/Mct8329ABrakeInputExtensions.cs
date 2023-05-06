namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    using System;

    public static class Mct8329ABrakeInputExtensions
    {
        public static string GetDescription(this Mct8329ABrakeInput brakeInput)
            => brakeInput switch
            {
                Mct8329ABrakeInput.HardwarePin => "Hardware pin",
                Mct8329ABrakeInput.BrakeAlwaysOn => "Always ON",
                Mct8329ABrakeInput.BrakeAlwaysOff => "Always OFF",
                _ => throw new NotSupportedException()
            };
    }
}
