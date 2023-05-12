namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329APwmModeExtensions
    {
        public static string GetDescription(this Mct8329APwmMode pwmMode)
            => pwmMode switch
            {
                Mct8329APwmMode.SingleEnded => "Single ended",
                Mct8329APwmMode.Complementary => "Complementary",
                _ => throw new NotSupportedException()
            };
    }
}
