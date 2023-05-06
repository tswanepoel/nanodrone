namespace Biscuits.Devices.FaultConfiguration
{
    public enum Mct8329ACbcILimitMode
    {
        AutoRecoveryOnNextPwmCycleWithFaultActive = 0x0,
        AutoRecoveryOnNextPwmCycleWithFaultInactive = 0x1,
        AutoRecoveryWhenCurrentFallsBelowILimitWithFaultActive = 0x2,
        AutoRecoveryWhenCurrentFallsBelowILimitWithFaultInactive = 0x3,
        AutoRecoveryAfterCbcRetryPwmCycWithFaultActive = 0x4,
        AutoRecoveryAfterCbcRetryPwmCycWithFaultInactive = 0x5,
        FaultActive = 0x6,
        Disabled1 = 0x7,
        Disabled2 = 0x8,
        Disabled3 = 0x9,
        Disabled4 = 0xA,
        Disabled5 = 0xB,
        Disabled6 = 0xC,
        Disabled7 = 0xD,
        Disabled8 = 0xE,
        Disabled9 = 0xF
    }
}
