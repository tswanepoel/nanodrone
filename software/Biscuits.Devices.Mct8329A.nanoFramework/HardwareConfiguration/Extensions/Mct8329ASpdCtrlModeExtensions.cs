using System;

namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    public static class Mct8329ASpdCtrlModeExtensions
    {
        public static string GetDescription(this Mct8329ASpdCtrlMode spdCtrlMode)
            => spdCtrlMode switch
            {
                Mct8329ASpdCtrlMode.AnalogMode => "Analog mode",
                Mct8329ASpdCtrlMode.PwmMode => "PWM mode",
                Mct8329ASpdCtrlMode.I2cMode => "I2C mode",
                Mct8329ASpdCtrlMode.FrequencyBased => "Frequency-based",
                _ => throw new NotSupportedException()
            };
    }
}
