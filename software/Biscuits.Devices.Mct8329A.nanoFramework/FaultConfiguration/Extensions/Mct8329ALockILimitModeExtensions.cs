namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;

    public static class Mct8329ALockILimitModeExtensions
    {
        public static string GetDescription(this Mct8329ALockILimitMode lockILimitMode)
            => lockILimitMode switch
            {
                Mct8329ALockILimitMode.LatchedFaultWithFaultActiveAndGateDriverTristated => "Latched fault; nFAULT active; driver is tristated",
                Mct8329ALockILimitMode.LatchedFaultWithFaultActiveAndGateDriverInRecirculationMode => "Latched fault; nFAULT active; driver is in recirculation mode",
                Mct8329ALockILimitMode.LatchedFaultWithFaultActiveAndGateDriverInHighSideBrakingMode => "Latched fault; nFault active; driver is in high-side braking mode",
                Mct8329ALockILimitMode.LatchedFaultWithFaultActiveAndGateDriverInLowSideBrakingMode => "Latched fault; nFault active; driver is in low-side braking mode",
                Mct8329ALockILimitMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverTristated => "Auto recovery after tLCK_RETRY; nFAULT active; driver is tristated",
                Mct8329ALockILimitMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInRecirculationMode => "Auto recovery after tLCK_RETRY; nFAULT active; driver is in recirculation mode",
                Mct8329ALockILimitMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInHighSideBrakingMode => "Auto recovery after tLCK_RETRY; nFAULT active; driver is in high-side braking mode",
                Mct8329ALockILimitMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInLowSideBrakingMode => "Auto recovery after tLCK_RETRY; nFAULT active; driver is in low-side braking mode",
                Mct8329ALockILimitMode.FaultActive => "No latched fault or auto recovery; nFAULT active",
                Mct8329ALockILimitMode.Disabled1 or
                    Mct8329ALockILimitMode.Disabled2 or
                    Mct8329ALockILimitMode.Disabled3 or
                    Mct8329ALockILimitMode.Disabled4 or
                    Mct8329ALockILimitMode.Disabled5 or
                    Mct8329ALockILimitMode.Disabled6 or
                    Mct8329ALockILimitMode.Disabled7 => "Disabled (nFAULT inactive)",
                _ => throw new NotSupportedException()
            };
    }
}
