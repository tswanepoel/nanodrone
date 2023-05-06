namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    using System;

    public static class Mct8329ATPWdthExtensions
    {
        public static string GetDescription(this Mct8329ATPWdth tpWdth)
            => $"{tpWdth.GetValue() * 1_000_000f} µs";
        
        public static float GetValue(this Mct8329ATPWdth tpWdth)
            => tpWdth switch
            {
                Mct8329ATPWdth.Value0us => 0f,
                Mct8329ATPWdth.Value1us => .000_001f,
                Mct8329ATPWdth.Value2us => .000_002f,
                Mct8329ATPWdth.Value3us => .000_003f,
                Mct8329ATPWdth.Value4us => .000_004f,
                Mct8329ATPWdth.Value5us => .000_005f,
                Mct8329ATPWdth.Value6us => .000_006f,
                Mct8329ATPWdth.Value7us => .000_007f,
                _ => throw new NotSupportedException()
            };
    }
}
