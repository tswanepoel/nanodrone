namespace Biscuits.Devices.HardwareConfiguration
{
    public static class Mct8329AExtClkConfigExtensions
    {
        public static string GetDescription(this Mct8329AExtClkConfig extClkConfig)
            => $"{GetValue(extClkConfig) / 1_000f} kHz";

        public static float GetValue(this Mct8329AExtClkConfig extClkConfig)
            => extClkConfig switch
            {
                Mct8329AExtClkConfig.Value8kHz => 8_000f,
                Mct8329AExtClkConfig.Value16kHz => 16_000f,
                Mct8329AExtClkConfig.Value32kHz => 32_000f,
                Mct8329AExtClkConfig.Value64kHz => 64_000f,
                Mct8329AExtClkConfig.Value128kHz => 128_000f,
                Mct8329AExtClkConfig.Value256kHz => 256_000f,
                Mct8329AExtClkConfig.Value512kHz => 512_000f,
                Mct8329AExtClkConfig.Value1024kHz => 1_024_000f,
                _ => throw new NotSupportedException()
            };
    }
}
