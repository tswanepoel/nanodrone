namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;

    public static class Mct8329ALockAbnSpeedExtensions
    {
        public static string GetDescription(this Mct8329ALockAbnSpeed lockAbnSpeed)
            => $"{GetValue(lockAbnSpeed)} Hz";

        public static float GetValue(this Mct8329ALockAbnSpeed lockAbnSpeed)
            => lockAbnSpeed switch
            {
                Mct8329ALockAbnSpeed.Value250Hz => 250f,
                Mct8329ALockAbnSpeed.Value500Hz => 500f,
                Mct8329ALockAbnSpeed.Value750Hz => 750f,
                Mct8329ALockAbnSpeed.Value1000Hz => 1_000f,
                Mct8329ALockAbnSpeed.Value1250Hz => 1_250f,
                Mct8329ALockAbnSpeed.Value1500Hz => 1_500f,
                Mct8329ALockAbnSpeed.Value1750Hz => 1_750f,
                Mct8329ALockAbnSpeed.Value2000Hz => 2_000f,
                Mct8329ALockAbnSpeed.Value2250Hz => 2_250f,
                Mct8329ALockAbnSpeed.Value2500Hz => 2_500f,
                Mct8329ALockAbnSpeed.Value2750Hz => 2_750f,
                Mct8329ALockAbnSpeed.Value3000Hz => 3_000f,
                Mct8329ALockAbnSpeed.Value3250Hz => 3_250f,
                Mct8329ALockAbnSpeed.Value3500Hz => 3_500f,
                Mct8329ALockAbnSpeed.Value3750Hz => 3_750f,
                Mct8329ALockAbnSpeed.Value4000Hz => 4_000f,
                _ => throw new NotSupportedException()
            };
    }
}
