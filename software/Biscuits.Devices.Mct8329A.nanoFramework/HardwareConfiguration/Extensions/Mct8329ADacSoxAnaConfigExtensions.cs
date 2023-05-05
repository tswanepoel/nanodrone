using System;

namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    public static class Mct8329ADacSoxAnaConfigExtensions
    {
        public static string GetDescription(this Mct8329ADacSoxAnaConfig dacSoxAnaConfig)
            => dacSoxAnaConfig switch
            {
                Mct8329ADacSoxAnaConfig.Dacout => "DACOUT",
                Mct8329ADacSoxAnaConfig.CsaOut => "CSA_OUT",
                Mct8329ADacSoxAnaConfig.AnaOnPin => "ANA_ON_PIN",
                _ => throw new NotSupportedException()
            };
    }
}
