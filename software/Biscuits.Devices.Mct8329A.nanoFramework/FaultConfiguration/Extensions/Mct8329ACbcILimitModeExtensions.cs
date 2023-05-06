namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;

    public static class Mct8329ACbcILimitModeExtensions
    {
        public static string GetDescription(this Mct8329ACbcILimitMode cbcILimitMode)
            => cbcILimitMode switch
            {
                Mct8329ACbcILimitMode.AutoRecoveryOnNextPwmCycleWithFaultActive => "Auto recovery on next PWM cycle; nFAULT active; driver is in recirculation mode",
                Mct8329ACbcILimitMode.AutoRecoveryOnNextPwmCycleWithFaultInactive => "Auto recovery on next PWM cycle; nFAULT inactive",
                Mct8329ACbcILimitMode.AutoRecoveryWhenCurrentFallsBelowILimitWithFaultActive => "Auto recovery when current falls below ILimit; nFault active; driver is in recirculation mode",
                Mct8329ACbcILimitMode.AutoRecoveryWhenCurrentFallsBelowILimitWithFaultInactive => "Auto recovery when current falls below ILimit; nFault inactive; driver is in recirculation mode",
                Mct8329ACbcILimitMode.AutoRecoveryAfterCbcRetryPwmCycWithFaultActive => "Auto recovery after CBC_RETRY_PWM_CYC; nFAULT active; driver is in recirculation mode",
                Mct8329ACbcILimitMode.AutoRecoveryAfterCbcRetryPwmCycWithFaultInactive => "Auto recovery after CBC_RETRY_PWM_CYC; nFAULT inactive; driver is in recirculation mode",
                Mct8329ACbcILimitMode.FaultActive => "No auto recovery; nFAULT active",
                Mct8329ACbcILimitMode.Disabled1 or
                    Mct8329ACbcILimitMode.Disabled2 or
                    Mct8329ACbcILimitMode.Disabled3 or
                    Mct8329ACbcILimitMode.Disabled4 or
                    Mct8329ACbcILimitMode.Disabled5 or
                    Mct8329ACbcILimitMode.Disabled6 or
                    Mct8329ACbcILimitMode.Disabled7 or
                    Mct8329ACbcILimitMode.Disabled8 or
                    Mct8329ACbcILimitMode.Disabled9 => "Disabled (nFAULT inactive)",
                _ => throw new NotSupportedException()
            };
    }
}
