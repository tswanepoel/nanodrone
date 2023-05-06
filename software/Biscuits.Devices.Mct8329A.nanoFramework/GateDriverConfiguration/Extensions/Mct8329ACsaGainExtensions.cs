namespace Biscuits.Devices.GateDriverConfiguration
{
    using System;

    public static class Mct8329ACsaGainExtensions
    {
        public static string GetDecription(this Mct8329ACsaGain csaGain)
            => $"{GetValue(csaGain)} V/V";

        public static float GetValue(this Mct8329ACsaGain csaGain)
            => csaGain switch
            {
                Mct8329ACsaGain.Value5VpV => 5f,
                Mct8329ACsaGain.Value10VpV => 10f,
                Mct8329ACsaGain.Value20VpV => 20f,
                Mct8329ACsaGain.Value40VpV => 40f,
                _ => throw new NotSupportedException()
            };
    }
}
