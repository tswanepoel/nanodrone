using System;

namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    public static class Mct8329ATBlankExtensions
    {
        public static string GetDescription(this Mct8329ATBlank tBlank)
            => $"{tBlank.GetValue() * 1_000_000f} µs";

        public static float GetValue(this Mct8329ATBlank tBlank)
            => tBlank switch
            {
                Mct8329ATBlank.Value0us => 0f,
                Mct8329ATBlank.Value1us => .000_001f,
                Mct8329ATBlank.Value2us => .000_002f,
                Mct8329ATBlank.Value3us => .000_003f,
                Mct8329ATBlank.Value4us => .000_004f,
                Mct8329ATBlank.Value5us => .000_005f,
                Mct8329ATBlank.Value6us => .000_006f,
                Mct8329ATBlank.Value7us => .000_007f,
                Mct8329ATBlank.Value8us => .000_008f,
                Mct8329ATBlank.Value9us => .000_009f,
                Mct8329ATBlank.Value10us => .000_01f,
                Mct8329ATBlank.Value11us => .000_011f,
                Mct8329ATBlank.Value12us => .000_012f,
                Mct8329ATBlank.Value13us => .000_013f,
                Mct8329ATBlank.Value14us => .000_014f,
                Mct8329ATBlank.Value15us => .000_015f,
                _ => throw new NotSupportedException()
            };
    }
}
