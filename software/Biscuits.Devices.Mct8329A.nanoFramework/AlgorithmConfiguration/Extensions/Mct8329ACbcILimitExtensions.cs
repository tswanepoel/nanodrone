namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ACbcILimitExtensions
    {
        public static string GetDescription(this Mct8329ACbcILimit cbcILimit)
            => $"{GetValue(cbcILimit):F1} V";

        public static float GetValue(this Mct8329ACbcILimit cbcILimit)
            => cbcILimit switch
            {
                Mct8329ACbcILimit.Value0mV => 0f,
                Mct8329ACbcILimit.Value100mV => .1f,
                Mct8329ACbcILimit.Value200mV => .2f,
                Mct8329ACbcILimit.Value300mV => .3f,
                Mct8329ACbcILimit.Value400mV => .4f,
                Mct8329ACbcILimit.Value500mV => .5f,
                Mct8329ACbcILimit.Value600mV => .6f,
                Mct8329ACbcILimit.Value700mV => .7f,
                Mct8329ACbcILimit.Value800mV => .8f,
                Mct8329ACbcILimit.Value900mV => .9f,
                Mct8329ACbcILimit.Value1000mV => 1f,
                Mct8329ACbcILimit.Value1100mV => 1.1f,
                Mct8329ACbcILimit.Value1200mV => 1.2f,
                Mct8329ACbcILimit.Value1300mV => 1.3f,
                Mct8329ACbcILimit.Value1400mV => 1.4f,
                Mct8329ACbcILimit.Value1500mV => 1.5f,
                Mct8329ACbcILimit.Value1600mV => 1.6f,
                Mct8329ACbcILimit.Value1700mV => 1.7f,
                Mct8329ACbcILimit.Value1800mV => 1.8f,
                Mct8329ACbcILimit.Value1900mV => 1.9f,
                Mct8329ACbcILimit.Value2000mV => 2f,
                Mct8329ACbcILimit.Value2100mV => 2.1f,
                Mct8329ACbcILimit.Value2200mV => 2.2f,
                Mct8329ACbcILimit.Value2300mV => 2.3f,
                Mct8329ACbcILimit.Value2400mV => 2.4f,
                Mct8329ACbcILimit.Value2500mV => 2.5f,
                Mct8329ACbcILimit.Value2600mV => 2.6f,
                _ => throw new NotSupportedException()
            };
    }
}
