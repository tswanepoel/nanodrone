namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;
    
    public static class Mct8329ALockILimitDegExtensions
    {
        public static string GetDescription(this Mct8329ALockILimitDeg lockILimitDeg)
            => $"{lockILimitDeg.GetValue():F3} s";

        public static float GetValue(this Mct8329ALockILimitDeg lockILimitDeg)
            => lockILimitDeg switch
            {
                Mct8329ALockILimitDeg.Value1ms => .001f,
                Mct8329ALockILimitDeg.Value2ms => .002f,
                Mct8329ALockILimitDeg.Value5ms => .005f,
                Mct8329ALockILimitDeg.Value10ms => .01f,
                Mct8329ALockILimitDeg.Value25ms => .025f,
                Mct8329ALockILimitDeg.Value50ms => .05f,
                Mct8329ALockILimitDeg.Value75ms => .075f,
                Mct8329ALockILimitDeg.Value100ms => .1f,
                Mct8329ALockILimitDeg.Value250ms => .25f,
                Mct8329ALockILimitDeg.Value500ms => .5f,
                Mct8329ALockILimitDeg.Value1000ms => 1f,
                Mct8329ALockILimitDeg.Value2500ms => 2.5f,
                Mct8329ALockILimitDeg.Value5000ms => 5f,
                Mct8329ALockILimitDeg.Value10000ms => 10f,
                Mct8329ALockILimitDeg.Value25000ms => 25f,
                Mct8329ALockILimitDeg.Value50000ms => 50f,
                _ => throw new NotSupportedException()
            };
    }
}
