namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AOLILimitConfigExtensions
    {
        public static string GetDescription(this Mct8329AOLILimitConfig oLILimitConfig)
            => oLILimitConfig switch
            {
                Mct8329AOLILimitConfig.DefinedByOLILimit => "Defined by OL_ILIMIT",
                Mct8329AOLILimitConfig.DefinedByCbcILimit => "Defined by CBC_ILIMIT",
                _ => throw new NotSupportedException()
            };
    }
}
