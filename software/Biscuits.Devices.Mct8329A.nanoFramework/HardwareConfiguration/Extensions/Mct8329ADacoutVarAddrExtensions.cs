namespace Biscuits.Devices.HardwareConfiguration.Extensions
{
    using System;

    public static class Mct8329ADacoutVarAddrExtensions
    {
        public static string GetDescription(this Mct8329ADacoutVarAddr dacoutVarAddr)
            => dacoutVarAddr switch
            {
                Mct8329ADacoutVarAddr.InputDuty => "INPUT_DUTY",
                Mct8329ADacoutVarAddr.CurrentDuty => "CURRENT_DUTY",
                Mct8329ADacoutVarAddr.SetDuty => "SET_DUTY",
                Mct8329ADacoutVarAddr.MotorSpeedPU => "MOTOR_SPEED_PU",
                Mct8329ADacoutVarAddr.DCBusPowerPU => "DC_BUS_POWER_PU",
                _ => throw new NotSupportedException()
            };
    }
}
