namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ACLDecConfigExtensions
    {
        public static string GetDescription(this Mct8329ACLDecConfig cLDecConfig)
            => cLDecConfig switch
            {
                Mct8329ACLDecConfig.DefinedByCLDec => "Defined by CL_DEC",
                Mct8329ACLDecConfig.DefinedByCLAcc => "Defined by CL_ACC",
                _ => throw new NotSupportedException()
            };
    }
}
