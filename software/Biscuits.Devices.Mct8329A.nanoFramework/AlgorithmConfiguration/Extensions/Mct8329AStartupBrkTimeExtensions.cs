namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AStartupBrkTimeExtensions
    {
        public static string GetDescription(this Mct8329AStartupBrkTime startupBrkTime)
            => $"{startupBrkTime.GetValue() * 1_000f} ms";

        public static float GetValue(this Mct8329AStartupBrkTime startupBrkTime)
            => startupBrkTime switch
            {
                Mct8329AStartupBrkTime.Value10ms => .01f,
                Mct8329AStartupBrkTime.Value50ms => .05f,
                Mct8329AStartupBrkTime.Value100ms => .1f,
                Mct8329AStartupBrkTime.Value200ms => .2f,
                Mct8329AStartupBrkTime.Value300ms => .3f,
                Mct8329AStartupBrkTime.Value400ms => .4f,
                Mct8329AStartupBrkTime.Value500ms => .5f,
                Mct8329AStartupBrkTime.Value1000ms => 1f,
                _ => throw new NotSupportedException()
            };
    }
}
