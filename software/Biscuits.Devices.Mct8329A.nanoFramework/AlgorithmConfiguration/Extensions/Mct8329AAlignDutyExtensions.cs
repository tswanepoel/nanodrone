namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AAlignDutyExtensions
    {
        public static string GetDescription(this Mct8329AAlignDuty alignDuty)
            => $"{alignDuty.GetValue() * 100f} %";

        public static float GetValue(this Mct8329AAlignDuty alignDuty)
            => alignDuty switch
            {
                Mct8329AAlignDuty.Value10Percent => 0.1f,
                Mct8329AAlignDuty.Value25Percent => 0.25f,
                Mct8329AAlignDuty.Value50Percent => 0.5f,
                Mct8329AAlignDuty.Value100Percent => 1f,
                _ => throw new NotSupportedException()
            };
    }
}
