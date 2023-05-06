namespace Biscuits.Devices.HardwareConfiguration
{
    using System;

    public static class Mct8329ADigDeadTimeExtensions
    {
        public static string GetDescription(this Mct8329ADigDeadTime digDeadTime)
            => $"{GetValue(digDeadTime) * 1_000_000_000f} ns";

        public static float GetValue(this Mct8329ADigDeadTime digDeadTime)
            => digDeadTime switch
            {
                Mct8329ADigDeadTime.Value0ns => 0f,
                Mct8329ADigDeadTime.Value50ns => .000_000_05f,
                Mct8329ADigDeadTime.Value100ns => .000_000_1f,
                Mct8329ADigDeadTime.Value150ns => .000_000_15f,
                Mct8329ADigDeadTime.Value200ns => .000_000_2f,
                Mct8329ADigDeadTime.Value250ns => .000_000_25f,
                Mct8329ADigDeadTime.Value300ns => .000_000_3f,
                Mct8329ADigDeadTime.Value350ns => .000_000_35f,
                Mct8329ADigDeadTime.Value400ns => .000_000_4f,
                Mct8329ADigDeadTime.Value450ns => .000_000_45f,
                Mct8329ADigDeadTime.Value500ns => .000_000_5f,
                Mct8329ADigDeadTime.Value600ns => .000_000_6f,
                Mct8329ADigDeadTime.Value700ns => .000_000_7f,
                Mct8329ADigDeadTime.Value800ns => .000_000_8f,
                Mct8329ADigDeadTime.Value900ns => .000_000_9f,
                Mct8329ADigDeadTime.Value1000ns => .000_001f,
                _ => throw new NotSupportedException()
            };
    }
}
