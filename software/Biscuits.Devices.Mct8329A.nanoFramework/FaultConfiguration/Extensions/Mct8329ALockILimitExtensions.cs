namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;

    public static class Mct8329ALockILimitExtensions
    {
        public static string GetDescription(this Mct8329ALockILimit lockILimit)
            => $"{GetValue(lockILimit):F1} V";

        public static float GetValue(this Mct8329ALockILimit lockILimit)
            => lockILimit switch
            {
                Mct8329ALockILimit.Value0mV => 0f,
                Mct8329ALockILimit.Value100mV => .1f,
                Mct8329ALockILimit.Value200mV => .2f,
                Mct8329ALockILimit.Value300mV => .3f,
                Mct8329ALockILimit.Value400mV => .4f,
                Mct8329ALockILimit.Value500mV => .5f,
                Mct8329ALockILimit.Value600mV => .6f,
                Mct8329ALockILimit.Value700mV => .7f,
                Mct8329ALockILimit.Value800mV => .8f,
                Mct8329ALockILimit.Value900mV => .9f,
                Mct8329ALockILimit.Value1000mV => 1f,
                Mct8329ALockILimit.Value1100mV => 1.1f,
                Mct8329ALockILimit.Value1200mV => 1.2f,
                Mct8329ALockILimit.Value1300mV => 1.3f,
                Mct8329ALockILimit.Value1400mV => 1.4f,
                Mct8329ALockILimit.Value1500mV => 1.5f,
                Mct8329ALockILimit.Value1600mV => 1.6f,
                Mct8329ALockILimit.Value1700mV => 1.7f,
                Mct8329ALockILimit.Value1800mV => 1.8f,
                Mct8329ALockILimit.Value1900mV => 1.9f,
                Mct8329ALockILimit.Value2000mV => 2f,
                Mct8329ALockILimit.Value2100mV => 2.1f,
                Mct8329ALockILimit.Value2200mV => 2.2f,
                Mct8329ALockILimit.Value2300mV => 2.3f,
                Mct8329ALockILimit.Value2400mV => 2.4f,
                Mct8329ALockILimit.Value2500mV => 2.5f,
                Mct8329ALockILimit.Value2600mV => 2.6f,
                Mct8329ALockILimit.Value2700mV => 2.7f,
                _ => throw new NotSupportedException()
            };
    }
}
