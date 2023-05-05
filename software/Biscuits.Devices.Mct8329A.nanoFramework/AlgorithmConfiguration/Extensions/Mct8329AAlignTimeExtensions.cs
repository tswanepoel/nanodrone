namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AAlignTimeExtensions
    {
        public static string GetDescription(this Mct8329AAlignTime alignTime)
            => $"{alignTime.GetValue()} s";

        public static float GetValue(this Mct8329AAlignTime alignTime)
            => alignTime switch
            {
                Mct8329AAlignTime.Value5ms => 0.005f,
                Mct8329AAlignTime.Value10ms => 0.01f,
                Mct8329AAlignTime.Value25ms => 0.025f,
                Mct8329AAlignTime.Value50ms => 0.05f,
                Mct8329AAlignTime.Value75ms => 0.075f,
                Mct8329AAlignTime.Value100ms => 0.1f,
                Mct8329AAlignTime.Value200ms => 0.2f,
                Mct8329AAlignTime.Value400ms => 0.4f,
                Mct8329AAlignTime.Value600ms => 0.6f,
                Mct8329AAlignTime.Value800ms => 0.8f,
                Mct8329AAlignTime.Value1000ms => 1f,
                Mct8329AAlignTime.Value2000ms => 2f,
                Mct8329AAlignTime.Value4000ms => 4f,
                Mct8329AAlignTime.Value6000ms => 5f,
                Mct8329AAlignTime.Value8000ms => 8f,
                Mct8329AAlignTime.Value10000ms => 10f,
                _ => throw new NotSupportedException()
            };
    }
}
