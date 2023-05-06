namespace Biscuits.Devices.GateDriverConfiguration
{
    public static class Mct8329AOtsAutoRecoveryExtensions
    {
        public static string GetDescription(this Mct8329AOtsAutoRecovery otsAutoRecovery)
            => otsAutoRecovery switch
            {
                Mct8329AOtsAutoRecovery.OtsLatchedFault => "OTS latched fault",
                Mct8329AOtsAutoRecovery.OtsAutoRecovery => "OTS auto recovery",
                _ => throw new NotSupportedException()
            };
    }
}
