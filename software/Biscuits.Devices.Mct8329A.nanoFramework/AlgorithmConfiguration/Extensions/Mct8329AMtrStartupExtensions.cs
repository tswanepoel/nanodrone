namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AMtrStartupExtensions
    {
        public static string GetDescription(this Mct8329AMtrStartup mtrStartup)
            => mtrStartup switch
            {
                Mct8329AMtrStartup.Align => "Align",
                Mct8329AMtrStartup.DoubleAlign => "Double align",
                Mct8329AMtrStartup.Ipd => "IPD",
                Mct8329AMtrStartup.SlowFirstCycle => "Slow first cycle",
                _ => throw new NotSupportedException()
            };
    }
}
