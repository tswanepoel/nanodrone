using System;

namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    public static class Mct8329AFGPinConfigExtensions
    {
        public static string GetDescription(this Mct8329AFGPinConfig fgPinConfig)
            => fgPinConfig switch
            {
                Mct8329AFGPinConfig.ContinueTogglingUntilMotorStops => "Continue toggling until motor stops",
                Mct8329AFGPinConfig.HiZStateWithExternalPullup => "Hi-Z state with external pullup",
                Mct8329AFGPinConfig.PulledLow => "Pulled low",
                _ => throw new NotSupportedException()
            };
    }
}
