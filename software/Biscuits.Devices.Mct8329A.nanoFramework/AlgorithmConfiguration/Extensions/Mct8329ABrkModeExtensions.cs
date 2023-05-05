namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ABrkModeExtensions
    {
        public static string GetDescription(this Mct8329ABrkMode brkMode)
            => brkMode switch
            {
                Mct8329ABrkMode.LowSide => "All three low-side FETs turned ON",
                Mct8329ABrkMode.HighSide => "All three high-side FETs turned ON",
                _ => throw new NotSupportedException()
            };
    }
}
