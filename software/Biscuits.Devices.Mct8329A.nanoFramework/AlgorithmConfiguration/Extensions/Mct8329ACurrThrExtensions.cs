namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ACurrThrExtensions
    {
        public static string GetDescription(this Mct8329ACurrThr currThr)
            => $"{currThr.GetValue():F1} V";

        public static float GetValue(this Mct8329ACurrThr currThr)
            => currThr switch
            {
                Mct8329ACurrThr.Value0mV => 0f,
                Mct8329ACurrThr.Value100mV => .1f,
                Mct8329ACurrThr.Value200mV => .2f,
                Mct8329ACurrThr.Value300mV => .3f,
                Mct8329ACurrThr.Value400mV => .4f,
                Mct8329ACurrThr.Value500mV => .5f,
                Mct8329ACurrThr.Value600mV => .6f,
                Mct8329ACurrThr.Value700mV => .7f,
                Mct8329ACurrThr.Value800mV => .8f,
                Mct8329ACurrThr.Value900mV => .9f,
                Mct8329ACurrThr.Value1000mV => 1f,
                Mct8329ACurrThr.Value1100mV => 1.1f,
                Mct8329ACurrThr.Value1200mV => 1.2f,
                Mct8329ACurrThr.Value1300mV => 1.3f,
                Mct8329ACurrThr.Value1400mV => 1.4f,
                Mct8329ACurrThr.Value1500mV => 1.5f,
                Mct8329ACurrThr.Value1600mV => 1.6f,
                Mct8329ACurrThr.Value1700mV => 1.7f,
                Mct8329ACurrThr.Value1800mV => 1.8f,
                Mct8329ACurrThr.Value1900mV => 1.9f,
                Mct8329ACurrThr.Value2000mV => 2f,
                Mct8329ACurrThr.Value2100mV => 2.1f,
                Mct8329ACurrThr.Value2200mV => 2.2f,
                Mct8329ACurrThr.Value2300mV => 2.3f,
                Mct8329ACurrThr.Value2400mV => 2.4f,
                Mct8329ACurrThr.Value2500mV => 2.5f,
                Mct8329ACurrThr.Value2600mV => 2.6f,
                _ => throw new NotSupportedException()
            };
    }
}
