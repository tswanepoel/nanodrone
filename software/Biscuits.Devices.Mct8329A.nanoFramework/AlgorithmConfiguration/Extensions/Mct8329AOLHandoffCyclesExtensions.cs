using System;

namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    public static class Mct8329AOLHandoffCyclesExtensions
    {
        public static string GetDescription(this Mct8329AOLHandoffCycles olHandoffCycles)
            => $"{olHandoffCycles.GetValue()}";

        public static int GetValue(this Mct8329AOLHandoffCycles olHandoffCycles)
            => olHandoffCycles switch
            {
                Mct8329AOLHandoffCycles.Value3 => 3,
                Mct8329AOLHandoffCycles.Value6 => 6,
                Mct8329AOLHandoffCycles.Value12 => 12,
                Mct8329AOLHandoffCycles.Value24 => 24,
                _ => throw new NotSupportedException()
            };
    }
}
