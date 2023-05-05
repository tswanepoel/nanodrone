using System;

namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    public static class Mct8329AStartupBrkTimeExtensions
    {
        public static string GetDescription(this Mct8329AStartupBrkTime startupBrkTime)
            => $"{startupBrkTime.GetValue()} s";

        public static float GetValue(this Mct8329AStartupBrkTime startupBrkTime)
            => startupBrkTime switch
            {
                Mct8329AStartupBrkTime.Value10ms => 0.01f,
                Mct8329AStartupBrkTime.Value50ms => 0.05f,
                Mct8329AStartupBrkTime.Value100ms => 0.1f,
                Mct8329AStartupBrkTime.Value200ms => 0.2f,
                Mct8329AStartupBrkTime.Value300ms => 0.3f,
                Mct8329AStartupBrkTime.Value400ms => 0.4f,
                Mct8329AStartupBrkTime.Value500ms => 0.5f,
                Mct8329AStartupBrkTime.Value1000ms => 1f,
                _ => throw new NotSupportedException()
            };
    }
}
