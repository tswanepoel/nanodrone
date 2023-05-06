namespace Biscuits.Devices.FaultConfiguration.Extensions
{
    using System;

    public static class Mct8329AMtrLckModeExtensions
    {
        public static string GetDescription(this Mct8329AMtrLckMode mtrLockMode)
            => mtrLockMode switch
            {
                Mct8329AMtrLckMode.LatchedFaultWithFaultActiveAndGateDriverTristated => "Latched fault; nFAULT active; driver is tristated",
                Mct8329AMtrLckMode.LatchedFaultWithFaultActiveAndGateDriverInRecirculationMode => "Latched fault; nFAULT active; driver is in recirculation mode",
                Mct8329AMtrLckMode.LatchedFaultWithFaultActiveAndGateDriverInHighSideBrakingMode => "Latched fault; nFault active; driver is in high-side braking mode",
                Mct8329AMtrLckMode.LatchedFaultWithFaultActiveAndGateDriverInLowSideBrakingMode => "Latched fault; nFault active; driver is in low-side braking mode",
                Mct8329AMtrLckMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverTristated => "Auto recovery after tLCK_RETRY; nFAULT active; driver is tristated",
                Mct8329AMtrLckMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInRecirculationMode => "Auto recovery after tLCK_RETRY; nFAULT active; driver is in recirculation mode",
                Mct8329AMtrLckMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInHighSideBrakingMode => "Auto recovery after tLCK_RETRY; nFAULT active; driver is in high-side braking mode",
                Mct8329AMtrLckMode.AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInLowSideBrakingMode => "Auto recovery after tLCK_RETRY; nFAULT active; driver is in low-side braking mode",
                Mct8329AMtrLckMode.FaultActive => "No latched fault or auto recovery; nFAULT active",
                Mct8329AMtrLckMode.Disabled1 or
                    Mct8329AMtrLckMode.Disabled2 or
                    Mct8329AMtrLckMode.Disabled3 or
                    Mct8329AMtrLckMode.Disabled4 or
                    Mct8329AMtrLckMode.Disabled5 or
                    Mct8329AMtrLckMode.Disabled6 or
                    Mct8329AMtrLckMode.Disabled7 => "Disabled (nFAULT inactive)",
                _ => throw new NotSupportedException()
            };
    }
}
