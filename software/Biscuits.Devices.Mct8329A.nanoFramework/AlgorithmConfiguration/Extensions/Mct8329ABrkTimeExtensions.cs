namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ABrkTimeExtensions
    {
        public static string GetDescription(this Mct8329ABrkTime brkTime)
            => $"{brkTime.GetValue()} s";

        public static float GetValue(this Mct8329ABrkTime brkTime)
            => brkTime switch
            {
                Mct8329ABrkTime.Value10ms => .01f,
                Mct8329ABrkTime.Value50ms => .05f,
                Mct8329ABrkTime.Value100ms => .1f,
                Mct8329ABrkTime.Value200ms => .2f,
                Mct8329ABrkTime.Value300ms => .3f,
                Mct8329ABrkTime.Value400ms => .4f,
                Mct8329ABrkTime.Value500ms => .5f,
                Mct8329ABrkTime.Value750ms => .75f,
                Mct8329ABrkTime.Value1000ms => 1f,
                Mct8329ABrkTime.Value2000ms => 2f,
                Mct8329ABrkTime.Value3000ms => 3f,
                Mct8329ABrkTime.Value4000ms => 4f,
                Mct8329ABrkTime.Value5000ms => 5f,
                Mct8329ABrkTime.Value7500ms => 7.5f,
                Mct8329ABrkTime.Value10000ms => 10f,
                Mct8329ABrkTime.Value15000ms => 15f,
                _ => throw new NotSupportedException()
            };
    }
}
