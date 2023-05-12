namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329APwmModulExtensions
    {
        public static string GetDescription(this Mct8329APwmModul pwmModul)
            => pwmModul switch
            {
                Mct8329APwmModul.HighSide => "High-side",
                Mct8329APwmModul.LowSide => "Low-side",
                Mct8329APwmModul.Mixed => "Mixed",
                _ => throw new NotSupportedException()
            };
    }
}
