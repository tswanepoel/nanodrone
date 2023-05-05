using System;

namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    public static class Mct8329AFGConfigExtensions
    {
        public static string GetDescription(this Mct8329AFGConfig fgConfig)
            => fgConfig switch
            {
                Mct8329AFGConfig.ActiveUntilSpeedDropsBelowBemfThreshold => "Active until speed drops below BEMF threshold defined by FG_BEMF_THR",
                Mct8329AFGConfig.ToggleAsLongAsMotorIsActivelyDriven => "Toggle as long as motor is actively driven",
                _ => throw new NotSupportedException()
            };
    }
}
