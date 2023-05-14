namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ASpdPowerVMinExtensions
    {
        public static string GetDescription(this Mct8329ASpdPowerVMin spdPowerVMin)
            => $"{spdPowerVMin.GetValue() * 100f:F1} %";

        public static float GetValue(this Mct8329ASpdPowerVMin spdPowerVMin)
            => spdPowerVMin switch
            {
                Mct8329ASpdPowerVMin.Value0Percent => 0f,
                Mct8329ASpdPowerVMin.Value2_5Percent => .025f,
                Mct8329ASpdPowerVMin.Value5Percent => .05f,
                Mct8329ASpdPowerVMin.Value7_5Percent => .075f,
                Mct8329ASpdPowerVMin.Value10Percent => .1f,
                Mct8329ASpdPowerVMin.Value15Percent => .15f,
                Mct8329ASpdPowerVMin.Value20Percent => .20f,
                Mct8329ASpdPowerVMin.Value25Percent => .25f,
                _ => throw new NotSupportedException()
            };
    }
}
