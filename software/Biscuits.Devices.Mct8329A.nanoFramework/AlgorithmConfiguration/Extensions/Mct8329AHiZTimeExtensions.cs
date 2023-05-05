namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AHiZTimeExtensions
    {
        public static string GetDescription(this Mct8329AHiZTime hiZTime)
            => $"{hiZTime.GetValue()} s";

        public static float GetValue(this Mct8329AHiZTime hiZTime)
            => hiZTime switch
            {
                Mct8329AHiZTime.Value10ms => 0.01f,
                Mct8329AHiZTime.Value50ms => 0.05f,
                Mct8329AHiZTime.Value100ms => 0.1f,
                Mct8329AHiZTime.Value200ms => 0.2f,
                Mct8329AHiZTime.Value300ms => 0.3f,
                Mct8329AHiZTime.Value400ms => 0.4f,
                Mct8329AHiZTime.Value500ms => 0.5f,
                Mct8329AHiZTime.Value750ms => 0.75f,
                Mct8329AHiZTime.Value1000ms => 1f,
                Mct8329AHiZTime.Value2000ms => 2f,
                Mct8329AHiZTime.Value3000ms => 3f,
                Mct8329AHiZTime.Value4000ms => 4f,
                Mct8329AHiZTime.Value5000ms => 5f,
                Mct8329AHiZTime.Value7500ms => 7.5f,
                Mct8329AHiZTime.Value10000ms => 10f,
                Mct8329AHiZTime.Value15000ms => 15f,
                _ => throw new NotSupportedException()
            };
    }
}
