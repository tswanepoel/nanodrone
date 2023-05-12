namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AMtrStopExtensions
    {
        public static string GetDescription(this Mct8329AMtrStop mtrStop)
            => mtrStop switch
            {
                Mct8329AMtrStop.HiZ => "Hi-Z",
                Mct8329AMtrStop.Recirculation => "Recirculation",
                Mct8329AMtrStop.LowSideBraking => "Low-side braking",
                Mct8329AMtrStop.HighSideBraking => "High-side braking",
                Mct8329AMtrStop.ActiveSpinDown => "Active spin down",
                _ => throw new NotSupportedException()
            };
    }
}
