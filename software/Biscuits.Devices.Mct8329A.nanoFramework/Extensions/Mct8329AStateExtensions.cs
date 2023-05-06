namespace Biscuits.Devices.Extensions
{
    public static class Mct8329AStateExtensions
    {
        public static string GetDescription(this Mct8329AState state)
            => state switch
            {
                Mct8329AState.SystemIdle => "SYSTEM_IDLE",
                Mct8329AState.MotorStart => "MOTOR_START",
                Mct8329AState.MotorRun => "MOTOR_RUN",
                Mct8329AState.SystemInit => "SYSTEM_INIT",
                Mct8329AState.MotorIpd => "MOTOR_IPD",
                Mct8329AState.MotorAlign => "MOTOR_ALIGN",
                Mct8329AState.MotorIdle => "MOTOR_IDLE",
                Mct8329AState.MotorStop => "MOTOR_STOP",
                Mct8329AState.Fault => "FAULT",
                Mct8329AState.MotorDirection => "MOTOR_DIRECTION",
                Mct8329AState.HallAlign => "HALL_ALIGN",
                Mct8329AState.MotorCalibrate => "MOTOR_CALIBRATE",
                Mct8329AState.MotorDescel => "MOTOR_DESCEL",
                Mct8329AState.MotorBrake => "MOTOR_BRAKE",
                _ => throw new NotSupportedException()
            };
    }
}
