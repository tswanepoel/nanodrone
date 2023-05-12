namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AActSpinBrkThrExtensions
    {
        public static string GetDescription(this Mct8329AActSpinBrkThr actSpinBrkThr)
            => actSpinBrkThr == Mct8329AActSpinBrkThr.Immediate ? "Immediate" : $"{actSpinBrkThr.GetValue() * 100f:F1} %";

        public static float GetValue(this Mct8329AActSpinBrkThr actSpinBrkThr)
            => actSpinBrkThr switch
            {
                Mct8329AActSpinBrkThr.Value50Percent => .5f,
                Mct8329AActSpinBrkThr.Value25Percent => .25f,
                Mct8329AActSpinBrkThr.Value15Percent => .15f,
                Mct8329AActSpinBrkThr.Value10Percent => .1f,
                Mct8329AActSpinBrkThr.Value7_5Percent => .075f,
                Mct8329AActSpinBrkThr.Value5Percent => .05f,
                Mct8329AActSpinBrkThr.Value2_5Percent => .025f,
                _ => throw new NotSupportedException()
            };
    }
}
