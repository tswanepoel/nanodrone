namespace Biscuits.Devices.HardwareConfiguration
{
    public enum Mct8329ADacoutVarAddr
    {
        InputDuty = 0x40C,
        CurrentDuty = 0x512,
        SetDuty = 0x522,
        MotorSpeedPU = 0x5CE,
        DCBusPowerPU = 0x714
    }
}
