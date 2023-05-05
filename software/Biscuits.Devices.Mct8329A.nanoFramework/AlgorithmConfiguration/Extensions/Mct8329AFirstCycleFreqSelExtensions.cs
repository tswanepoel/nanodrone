namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AFirstCycleFreqSelExtensions
    {
        public static string GetDescription(this Mct8329AFirstCycleFreqSel firstCycleFreqSel)
            => firstCycleFreqSel switch
            {
                Mct8329AFirstCycleFreqSel.DefinedBySlowFirstCycFreq => "Defined by SLOW_FIRST_CYC_FREQ",
                Mct8329AFirstCycleFreqSel.Value0Hz => "0 Hz",
                _ => throw new NotSupportedException()
            };
    }
}
