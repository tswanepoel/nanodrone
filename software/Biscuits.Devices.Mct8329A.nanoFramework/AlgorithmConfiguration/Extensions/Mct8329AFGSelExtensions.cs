namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AFGSelExtensions
    {
        public static string GetDescription(this Mct8329AFGSel fGSel)
            => fGSel switch
            {
                Mct8329AFGSel.OutputFGInOpenLoopAndClosedLoop => "Output FG in open loop and closed loop",
                Mct8329AFGSel.OutputFGInOnlyClosedLoop => "Output FG in only closed loop",
                Mct8329AFGSel.OutputFGInOpenLoopForTheFirstTry => "Output FG in open loop for the first try",
                _ => throw new NotSupportedException()
            };
    }
}
