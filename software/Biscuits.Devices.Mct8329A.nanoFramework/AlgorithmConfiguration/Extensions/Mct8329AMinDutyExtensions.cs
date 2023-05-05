namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AMinDutyExtensions
    {
        public static string GetDescription(this Mct8329AMinDuty minDuty)
            => $"{minDuty.GetValue() * 100f} %";

        public static float GetValue(this Mct8329AMinDuty minDuty)
            => minDuty switch
            {
                Mct8329AMinDuty.Value0Percent => 0f,
                Mct8329AMinDuty.Value1_5Percent => 0.015f,
                Mct8329AMinDuty.Value2_5Percent => 0.025f,
                Mct8329AMinDuty.Value3Percent => 0.03f,
                Mct8329AMinDuty.Value4Percent => 0.04f,
                Mct8329AMinDuty.Value5Percent => 0.05f,
                Mct8329AMinDuty.Value6Percent => 0.06f,
                Mct8329AMinDuty.Value7Percent => 0.07f,
                Mct8329AMinDuty.Value8Percent => 0.08f,
                Mct8329AMinDuty.Value9Percent => 0.09f,
                Mct8329AMinDuty.Value10Percent => 0.1f,
                Mct8329AMinDuty.Value12Percent => 0.12f,
                Mct8329AMinDuty.Value15Percent => 0.15f,
                Mct8329AMinDuty.Value17_5Percent => 0.175f,
                Mct8329AMinDuty.Value20Percent => 0.2f,
                Mct8329AMinDuty.Value25Percent => 0.25f,
                _ => throw new NotSupportedException()
            };
    }
}
