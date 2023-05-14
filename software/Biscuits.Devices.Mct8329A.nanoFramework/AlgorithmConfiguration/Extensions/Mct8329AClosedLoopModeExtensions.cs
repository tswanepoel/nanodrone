namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AClosedLoopModeExtensions
    {
        public static string GetDescription(this Mct8329AClosedLoopMode closedLoopMode)
            => closedLoopMode switch
            {
                Mct8329AClosedLoopMode.Disabled => "Disabled",
                Mct8329AClosedLoopMode.SpeedLoop => "Speed loop",
                Mct8329AClosedLoopMode.PowerLoop => "Power loop",
                _ => throw new NotSupportedException()
            };
    }
}
