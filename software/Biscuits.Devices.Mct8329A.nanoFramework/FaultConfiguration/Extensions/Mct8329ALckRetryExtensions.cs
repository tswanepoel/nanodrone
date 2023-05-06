namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;

    public static class Mct8329ALckRetryExtensions
    {
        public static string GetDescription(this Mct8329ALckRetry lckRetry)
            => $"{GetValue(lckRetry) * 1_000f} ms";

        public static float GetValue(this Mct8329ALckRetry lckRetry)
            => lckRetry switch
            {
                Mct8329ALckRetry.Value100ms => .1f,
                Mct8329ALckRetry.Value500ms => .5f,
                Mct8329ALckRetry.Value1000ms => 1f,
                Mct8329ALckRetry.Value2000ms => 2f,
                Mct8329ALckRetry.Value3000ms => 3f,
                Mct8329ALckRetry.Value5000ms => 5f,
                Mct8329ALckRetry.Value7500ms => 7.5f,
                Mct8329ALckRetry.Value10000ms => 10f,
                _ => throw new NotSupportedException()
            };
    }
}
