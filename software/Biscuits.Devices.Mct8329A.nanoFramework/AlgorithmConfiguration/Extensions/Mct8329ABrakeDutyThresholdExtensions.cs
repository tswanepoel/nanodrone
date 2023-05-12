namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ABrakeDutyThresholdExtensions
    {
        public static string GetDescription(this Mct8329ABrakeDutyThreshold brakeDutyThreshold)
            => brakeDutyThreshold == Mct8329ABrakeDutyThreshold.Immediate ? "Immediate" : $"{brakeDutyThreshold.GetValue() * 100f:F1} %";

        public static float GetValue(this Mct8329ABrakeDutyThreshold brakeDutyThreshold)
            => brakeDutyThreshold switch
            {
                Mct8329ABrakeDutyThreshold.Value50Percent => .5f,
                Mct8329ABrakeDutyThreshold.Value25Percent => .25f,
                Mct8329ABrakeDutyThreshold.Value15Percent => .15f,
                Mct8329ABrakeDutyThreshold.Value10Percent => .1f,
                Mct8329ABrakeDutyThreshold.Value7_5Percent => .075f,
                Mct8329ABrakeDutyThreshold.Value5Percent => .05f,
                Mct8329ABrakeDutyThreshold.Value2_5Percent => .025f,
                _ => throw new NotSupportedException()
            };
    }
}
