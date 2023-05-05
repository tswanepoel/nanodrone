namespace Biscuits.Devices
{
    public enum Mct8329AState
    {
        SystemIdle = 0x0,
        MotorStart = 0x1,
        MotorRun = 0x2,
        SystemInit = 0x3,
        MotorIpd = 0x4,
        MotorAlign = 0x5,
        MotorIdle = 0x6,
        MotorStop = 0x7,
        Fault = 0x8,
        MotorDirection = 0x9,
        HallAlign = 0xA,
        MotorCalibrate = 0xC,
        MotorDescel = 0xD,
        MotorBrake = 0xE
    }
}
