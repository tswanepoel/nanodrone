namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AStartupBrkTimeExtensions
    {
        public static string GetDescription(this Mct8329AStartupBrkTime startupBrkTime)
            => $"{startupBrkTime.GetValue():F3} s";

        public static float GetValue(this Mct8329AStartupBrkTime startupBrkTime)
            => startupBrkTime switch
            {
                Mct8329AStartupBrkTime.Value1ms => .001f,
                Mct8329AStartupBrkTime.Value10ms => .01f,
                Mct8329AStartupBrkTime.Value25ms => .025f,
                Mct8329AStartupBrkTime.Value50ms => .05f,
                Mct8329AStartupBrkTime.Value100ms => .1f,
                Mct8329AStartupBrkTime.Value250ms => .25f,
                Mct8329AStartupBrkTime.Value500ms => .5f,
                Mct8329AStartupBrkTime.Value1000ms => 1f,
                _ => throw new NotSupportedException()
            };
    }
}
