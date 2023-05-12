namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AFGBemfThrExtensions
    {
        public static string GetDescription(this Mct8329AFGBemfThr fGBemfThr)
           => $"+/- {fGBemfThr.GetValue() * 1_000f} mV";

        public static float GetValue(this Mct8329AFGBemfThr fGBemfThr)
            => fGBemfThr switch
            {
                Mct8329AFGBemfThr.Approx1mV => .001f,
                Mct8329AFGBemfThr.Approx2mV => .002f,
                Mct8329AFGBemfThr.Approx5mV => .005f,
                Mct8329AFGBemfThr.Approx10mV => .01f,
                Mct8329AFGBemfThr.Approx20mV => .02f,
                Mct8329AFGBemfThr.Approx30mV => .03f,
                _ => throw new NotSupportedException()
            };
    }
}
