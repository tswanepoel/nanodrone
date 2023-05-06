namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;

    public static class Mct8329ANoMtrDegTimeExtensions
    {
        public static string GetDescription(this Mct8329ANoMtrDegTime noMtrDegTime)
            => $"{GetValue(noMtrDegTime) * 1_000f} ms";

        public static float GetValue(this Mct8329ANoMtrDegTime noMtrDegTime)
            => noMtrDegTime switch
            {
                Mct8329ANoMtrDegTime.Value1ms => .001f,
                Mct8329ANoMtrDegTime.Value10ms => .01f,
                Mct8329ANoMtrDegTime.Value25ms => .025f,
                Mct8329ANoMtrDegTime.Value50ms => .05f,
                Mct8329ANoMtrDegTime.Value100ms => .1f,
                Mct8329ANoMtrDegTime.Value250ms => .25f,
                Mct8329ANoMtrDegTime.Value500ms => .5f,
                Mct8329ANoMtrDegTime.Value1000ms => 1f,
                _ => throw new NotSupportedException()
            };
    }
}
