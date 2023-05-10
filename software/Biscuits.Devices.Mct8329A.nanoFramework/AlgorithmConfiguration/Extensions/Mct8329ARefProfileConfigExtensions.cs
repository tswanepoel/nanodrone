namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ARefProfileConfigExtensions
    {
        public static string GetDescription(this Mct8329ARefProfileConfig refProfileConfig)
           => refProfileConfig switch
           {
               Mct8329ARefProfileConfig.DutyControlMode => "Duty control mode",
               Mct8329ARefProfileConfig.LinearMode => "Linear mode",
               Mct8329ARefProfileConfig.StaircaseMode => "Staircase mode",
               Mct8329ARefProfileConfig.ForwardReverseMode => "Forward-reverse mode",
               _ => throw new NotSupportedException()
           };
    }
}
