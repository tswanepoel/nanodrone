namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AMtrStopBrkTimeExtensions
    {
        public static string GetDescription(this Mct8329AMtrStopBrkTime mtrStopBrkTime)
            => $"{mtrStopBrkTime.GetValue():F3} s";

        public static float GetValue(this Mct8329AMtrStopBrkTime mtrStopBrkTime)
            => mtrStopBrkTime switch
            {
                Mct8329AMtrStopBrkTime.Value1ms => .001f,
                Mct8329AMtrStopBrkTime.Value2ms => .002f,
                Mct8329AMtrStopBrkTime.Value5ms => .005f,
                Mct8329AMtrStopBrkTime.Value10ms => .01f,
                Mct8329AMtrStopBrkTime.Value15ms => .015f,
                Mct8329AMtrStopBrkTime.Value25ms => .025f,
                Mct8329AMtrStopBrkTime.Value50ms => .05f,
                Mct8329AMtrStopBrkTime.Value75ms => .075f,
                Mct8329AMtrStopBrkTime.Value100ms => .1f,
                Mct8329AMtrStopBrkTime.Value250ms => .25f,
                Mct8329AMtrStopBrkTime.Value500ms => .5f,
                Mct8329AMtrStopBrkTime.Value1000ms => 1f,
                Mct8329AMtrStopBrkTime.Value2500ms => 2.5f,
                Mct8329AMtrStopBrkTime.Value5000ms => 5f,
                Mct8329AMtrStopBrkTime.Value10000ms => 10f,
                Mct8329AMtrStopBrkTime.Value15000ms => 15f,
                _ => throw new NotSupportedException()
            };
    }
}
