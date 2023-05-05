namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AIpdClkFreqExtensions
    {
        public static string GetDescription(this Mct8329AIpdClkFreq ipdCklFreq)
            => $"{ipdCklFreq.GetValue()} Hz";

        public static float GetValue(this Mct8329AIpdClkFreq ipdCklFreq)
            => ipdCklFreq switch
            {
                Mct8329AIpdClkFreq.Value50Hz => 50f,
                Mct8329AIpdClkFreq.Value100Hz => 100f,
                Mct8329AIpdClkFreq.Value250Hz => 250f,
                Mct8329AIpdClkFreq.Value500Hz => 500f,
                Mct8329AIpdClkFreq.Value1000Hz => 1_000f,
                Mct8329AIpdClkFreq.Value2000Hz => 2_000f,
                Mct8329AIpdClkFreq.Value5000Hz => 5_000f,
                Mct8329AIpdClkFreq.Value10000Hz => 10_000f,
                _ => throw new NotSupportedException()
            };
    }
}
