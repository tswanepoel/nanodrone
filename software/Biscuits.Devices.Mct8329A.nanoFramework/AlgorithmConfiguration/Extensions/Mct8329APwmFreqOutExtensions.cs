namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329APwmFreqOutExtensions
    {
        public static string GetDescription(this Mct8329APwmFreqOut pwmFreqOut)
            => $"{pwmFreqOut.GetValue() / 1_000f} kHz";

        public static float GetValue(this Mct8329APwmFreqOut pwmFreqOut)
            => pwmFreqOut switch
            {
                Mct8329APwmFreqOut.Value5kHz => 5_000f,
                Mct8329APwmFreqOut.Value6kHz => 6_000f,
                Mct8329APwmFreqOut.Value7kHz => 7_000f,
                Mct8329APwmFreqOut.Value8kHz => 8_000f,
                Mct8329APwmFreqOut.Value9kHz => 9_000f,
                Mct8329APwmFreqOut.Value10kHz => 10_000f,
                Mct8329APwmFreqOut.Value11kHz => 11_000f,
                Mct8329APwmFreqOut.Value12kHz => 12_000f,
                Mct8329APwmFreqOut.Value13kHz => 13_000f,
                Mct8329APwmFreqOut.Value14kHz => 14_000f,
                Mct8329APwmFreqOut.Value15kHz => 15_000f,
                Mct8329APwmFreqOut.Value16kHz => 16_000f,
                Mct8329APwmFreqOut.Value17kHz => 17_000f,
                Mct8329APwmFreqOut.Value18kHz => 18_000f,
                Mct8329APwmFreqOut.Value19kHz => 19_000f,
                Mct8329APwmFreqOut.Value20kHz => 20_000f,
                Mct8329APwmFreqOut.Value25kHz => 25_000f,
                Mct8329APwmFreqOut.Value30kHz => 30_000f,
                Mct8329APwmFreqOut.Value35kHz => 35_000f,
                Mct8329APwmFreqOut.Value40kHz => 40_000f,
                Mct8329APwmFreqOut.Value45kHz => 45_000f,
                Mct8329APwmFreqOut.Value50kHz => 50_000f,
                Mct8329APwmFreqOut.Value55kHz => 55_000f,
                Mct8329APwmFreqOut.Value60kHz => 60_000f,
                Mct8329APwmFreqOut.Value65kHz => 65_000f,
                Mct8329APwmFreqOut.Value70kHz => 70_000f,
                Mct8329APwmFreqOut.Value75kHz => 75_000f,
                Mct8329APwmFreqOut.Value80kHz => 80_000f,
                Mct8329APwmFreqOut.Value85kHz => 85_000f,
                Mct8329APwmFreqOut.Value90kHz => 90_000f,
                Mct8329APwmFreqOut.Value95kHz => 95_000f,
                Mct8329APwmFreqOut.Value100kHz => 100_000f,
                _ => throw new NotSupportedException()
            };
    }
}
