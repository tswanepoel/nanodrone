namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AIpdAdvAngleExtensions
    {
        public static string GetDescription(this Mct8329AIpdAdvAngle ipdAdvAngle)
            => $"{ipdAdvAngle.GetValue()} °";

        public static float GetValue(this Mct8329AIpdAdvAngle ipdAdvAngle)
            => ipdAdvAngle switch
            {
                Mct8329AIpdAdvAngle.Value0Degrees => 0f,
                Mct8329AIpdAdvAngle.Value30Degrees => 30f,
                Mct8329AIpdAdvAngle.Value60Degrees => 60f,
                Mct8329AIpdAdvAngle.Value90Degrees => 90f,
                _ => throw new NotSupportedException()
            };
    }
}
