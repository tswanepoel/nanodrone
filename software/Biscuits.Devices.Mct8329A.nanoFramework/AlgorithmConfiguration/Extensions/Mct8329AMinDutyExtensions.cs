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
                Mct8329AMinDuty.Value1_5Percent => .015f,
                Mct8329AMinDuty.Value2_5Percent => .025f,
                Mct8329AMinDuty.Value3Percent => .03f,
                Mct8329AMinDuty.Value4Percent => .04f,
                Mct8329AMinDuty.Value5Percent => .05f,
                Mct8329AMinDuty.Value6Percent => .06f,
                Mct8329AMinDuty.Value7Percent => .07f,
                Mct8329AMinDuty.Value8Percent => .08f,
                Mct8329AMinDuty.Value9Percent => .09f,
                Mct8329AMinDuty.Value10Percent => .1f,
                Mct8329AMinDuty.Value12Percent => .12f,
                Mct8329AMinDuty.Value15Percent => .15f,
                Mct8329AMinDuty.Value17_5Percent => .175f,
                Mct8329AMinDuty.Value20Percent => .2f,
                Mct8329AMinDuty.Value25Percent => .25f,
                _ => throw new NotSupportedException()
            };
    }
}
