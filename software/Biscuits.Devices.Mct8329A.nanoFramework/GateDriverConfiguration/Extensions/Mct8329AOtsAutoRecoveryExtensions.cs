namespace Biscuits.Devices.GateDriverConfiguration
{
    using System;

    public static class Mct8329AOtsAutoRecoveryExtensions
    {
        public static string GetDescription(this Mct8329AOtsAutoRecovery otsAutoRecovery)
            => otsAutoRecovery switch
            {
                Mct8329AOtsAutoRecovery.LatchedFault => "Latched fault",
                Mct8329AOtsAutoRecovery.AutoRecovery => "Auto recovery",
                _ => throw new NotSupportedException()
            };
    }
}
