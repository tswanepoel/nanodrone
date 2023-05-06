namespace Biscuits.Devices.HardwareConfiguration
{
    using System;

    public static class Mct8329ADevModeExtensions
    {
        public static string GetDescription(this Mct8329ADevMode devMode)
            => devMode switch
            {
                Mct8329ADevMode.Standby => "Standby mode",
                Mct8329ADevMode.Sleep => "Sleep mode",
                _ => throw new NotSupportedException()
            };
    }
}
