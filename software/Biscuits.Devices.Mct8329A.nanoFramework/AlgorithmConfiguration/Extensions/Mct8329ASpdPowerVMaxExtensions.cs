namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ASpdPowerVMaxExtensions
    {
        public static string GetDescription(this Mct8329ASpdPowerVMax spdPowerVMax)
            => $"{spdPowerVMax.GetValue() * 100f:F1} %";

        public static float GetValue(this Mct8329ASpdPowerVMax spdPowerVMax)
            => spdPowerVMax switch
            {
                Mct8329ASpdPowerVMax.Value100Percent => 1f,
                Mct8329ASpdPowerVMax.Value95Percent => .95f,
                Mct8329ASpdPowerVMax.Value90Percent => .9f,
                Mct8329ASpdPowerVMax.Value85Percent => .85f,
                Mct8329ASpdPowerVMax.Value80Percent => .8f,
                Mct8329ASpdPowerVMax.Value75Percent => .75f,
                Mct8329ASpdPowerVMax.Value70Percent => .7f,
                Mct8329ASpdPowerVMax.Value65Percent => .65f,
                _ => throw new NotSupportedException()
            };
    }
}
