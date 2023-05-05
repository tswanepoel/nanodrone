using System;

namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    public static class Mct8329ASlowFirstCycFreqExtensions
    {
        public static string GetDescription(this Mct8329ASlowFirstCycFreq slowFirstCycFreq)
            => $"{slowFirstCycFreq.GetValue()} Hz";

        public static float GetValue(this Mct8329ASlowFirstCycFreq slowFirstCycFreq)
            => slowFirstCycFreq switch
            {
                Mct8329ASlowFirstCycFreq.Value50mHz => 0.05f,
                Mct8329ASlowFirstCycFreq.Value100mHz => 0.1f,
                Mct8329ASlowFirstCycFreq.Value200mHz => 0.2f,
                Mct8329ASlowFirstCycFreq.Value500mHz => 0.5f,
                Mct8329ASlowFirstCycFreq.Value1000mHz => 1f,
                Mct8329ASlowFirstCycFreq.Value2000mHz => 2f,
                Mct8329ASlowFirstCycFreq.Value3000mHz => 3f,
                Mct8329ASlowFirstCycFreq.Value5000mHz => 5f,
                Mct8329ASlowFirstCycFreq.Value10000mHz => 10f,
                Mct8329ASlowFirstCycFreq.Value15000mHz => 15f,
                Mct8329ASlowFirstCycFreq.Value25000mHz => 25f,
                Mct8329ASlowFirstCycFreq.Value50000mHz => 50f,
                Mct8329ASlowFirstCycFreq.Value100000mHz => 100f,
                Mct8329ASlowFirstCycFreq.Value150000mHz => 150f,
                Mct8329ASlowFirstCycFreq.Value200000mHz => 200f,
                _ => throw new NotSupportedException()
            };
    }
}
