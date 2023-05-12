namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AIntegZCMethodExtensions
    {
        public static string GetDescription(this Mct8329AIntegZCMethod integZCMethod)
            => integZCMethod switch
            {
                Mct8329AIntegZCMethod.ZCBased => "ZC based",
                Mct8329AIntegZCMethod.IntegrationBased => "Integration based",
                _ => throw new NotSupportedException()
            };
    }
}
