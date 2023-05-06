namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    using System;

    public static class Mct8329AZeroDutyHystExtensions
    {
        public static string GetDescription(this Mct8329AZeroDutyHyst zeroDutyHyst)
            => $"{zeroDutyHyst.GetValue() * 100f} %";

        public static float GetValue(this Mct8329AZeroDutyHyst zeroDutyHyst)
            => zeroDutyHyst switch
            {
                Mct8329AZeroDutyHyst.Hyst0Percent => 0f,
                Mct8329AZeroDutyHyst.Hyst2Percent => .02f,
                Mct8329AZeroDutyHyst.Hyst4Percent => .04f,
                Mct8329AZeroDutyHyst.Hyst6Percent => .06f,
                _ => throw new NotSupportedException()
            };
    }
}
