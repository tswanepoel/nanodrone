namespace Biscuits.Devices.FaultConfiguration
{
    public enum Mct8329ALockILimitMode
    {
        LatchedFaultWithFaultActiveAndGateDriverTristated = 0x0,
        LatchedFaultWithFaultActiveAndGateDriverInRecirculationMode = 0x1,
        LatchedFaultWithFaultActiveAndGateDriverInHighSideBrakingMode = 0x2,
        LatchedFaultWithFaultActiveAndGateDriverInLowSideBrakingMode = 0x3,
        AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverTristated = 0x4,
        AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInRecirculationMode = 0x5,
        AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInHighSideBrakingMode = 0x6,
        AutoRecoveryAfterTLckRetryWithFaultActiveAndGateDriverInLowSideBrakingMode = 0x7,
        FaultActive = 0x8,
        Disabled1 = 0x9,
        Disabled2 = 0xA,
        Disabled3 = 0xB,
        Disabled4 = 0xC,
        Disabled5 = 0xD,
        Disabled6 = 0xE,
        Disabled7 = 0xF
    }
}
