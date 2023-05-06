namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AAlignRampRateExtensions
    {
        public static string GetDescription(this Mct8329AAlignRampRate alignRampRate)
            => $"{alignRampRate.GetValue():F1} V/s";

        public static float GetValue(this Mct8329AAlignRampRate alignRampRate)
            => alignRampRate switch
            {
                Mct8329AAlignRampRate.Value100mVps => .1f,
                Mct8329AAlignRampRate.Value200mVps => .2f,
                Mct8329AAlignRampRate.Value500mVps => .5f,
                Mct8329AAlignRampRate.Value1000mVps => 1f,
                Mct8329AAlignRampRate.Value2500mVps => 2.5f,
                Mct8329AAlignRampRate.Value5000mVps => 5f,
                Mct8329AAlignRampRate.Value7500mVps => 7.5f,
                Mct8329AAlignRampRate.Value10000mVps => 10f,
                Mct8329AAlignRampRate.Value25000mVps => 25f,
                Mct8329AAlignRampRate.Value50000mVps => 50f,
                Mct8329AAlignRampRate.Value75000mVps => 75f,
                Mct8329AAlignRampRate.Value100000mVps => 100f,
                Mct8329AAlignRampRate.Value250000mVps => 250f,
                Mct8329AAlignRampRate.Value500000mVps => 500f,
                Mct8329AAlignRampRate.Value750000mVps => 750f,
                Mct8329AAlignRampRate.Value1000000mVps => 1_000f,
                _ => throw new NotSupportedException()
            };
    }
}
