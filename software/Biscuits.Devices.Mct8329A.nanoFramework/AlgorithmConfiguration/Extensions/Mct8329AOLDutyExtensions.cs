using System;

namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    public static class Mct8329AOLDutyExtensions
    {
        public static string GetDescription(this Mct8329AOLDuty olDuty)
            => $"{olDuty.GetValue() * 100f} %";

        public static float GetValue(this Mct8329AOLDuty olDuty)
            => olDuty switch
            {
                Mct8329AOLDuty.Value10Percent => 0.1f,
                Mct8329AOLDuty.Value15Percent => 0.15f,
                Mct8329AOLDuty.Value20Percent => 0.2f,
                Mct8329AOLDuty.Value25Percent => 0.25f,
                Mct8329AOLDuty.Value30Percent => 0.3f,
                Mct8329AOLDuty.Value40Percent => 0.4f,
                Mct8329AOLDuty.Value50Percent => 0.5f,
                Mct8329AOLDuty.Value100Percent => 1f,
                _ => throw new NotSupportedException()
            };
    }
}
