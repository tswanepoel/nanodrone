namespace Biscuits.Devices.GateDriverConfiguration
{
    public static class Mct8329ACsaGainExtensions
    {
        public static string GetDecription(this Mct8329ACsaGain csaGain)
            => $"{GetValue(csaGain)} V/V";

        public static float GetValue(this Mct8329ACsaGain csaGain)
            => csaGain switch
            {
                Mct8329ACsaGain.Value5VpV => 5f,
                Mct8329ACsaGain.Value10VpV => 10f,
                Mct8329ACsaGain.Value15VpV => 15f,
                Mct8329ACsaGain.Value20VpV => 20f,
                _ => throw new NotSupportedException()
            };
    }
}
