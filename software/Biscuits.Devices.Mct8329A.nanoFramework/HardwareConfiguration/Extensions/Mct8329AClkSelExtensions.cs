namespace Biscuits.Devices.HardwareConfiguration
{
    public static class Mct8329AClkSelExtensions
    {
        public static string GetDescription(this Mct8329AClkSel clkSel)
            => clkSel switch
            {
                Mct8329AClkSel.Internal => "Internal",
                Mct8329AClkSel.External => "External",
                _ => throw new NotSupportedException()
            };
    }
}
