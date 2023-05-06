namespace Biscuits.Devices.GateDriverConfiguration
{
    public static class Mct8329AVRefSelExtensions
    {
        public static string GetDescription(this Mct8329AVRefSel vRefSel)
            => vRefSel switch
            {
                Mct8329AVRefSel.UniDirectionalCsa => "Uni-directional",
                Mct8329AVRefSel.BiDirectionalCsa => "Bi-directional",
                _ => throw new NotSupportedException()
            };
    }
}
