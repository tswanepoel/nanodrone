namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AFGDivFactorExtensions
    {
        public static string GetDescription(this Mct8329AFGDivFactor fGDivFactor)
            => fGDivFactor switch
            {
                Mct8329AFGDivFactor.DivideBy3_2PoleMotorMechanicalSpeedTimes3 => "Divide by 3 (2-pole motor mechanical speed*3)",
                Mct8329AFGDivFactor.DivideBy1_2PoleMotorMechanicalSpeed => "Divide by 1 (2-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy2_4PoleMotorMechanicalSpeed => "Divide by 2 (4-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy3_6PoleMotorMechanicalSpeed => "Divide by 3 (6-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy4_8PoleMotorMechanicalSpeed => "Divide by 4 (8-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy5_10PoleMotorMechanicalSpeed => "Divide by 5 (10-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy6_12PoleMotorMechanicalSpeed => "Divide by 6 (12-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy7_14PoleMotorMechanicalSpeed => "Divide by 7 (14-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy8_16PoleMotorMechanicalSpeed => "Divide by 8 (16-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy9_18PoleMotorMechanicalSpeed => "Divide by 9 (18-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy10_20PoleMotorMechanicalSpeed => "Divide by 10 (20-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy11_22PoleMotorMechanicalSpeed => "Divide by 11 (22-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy12_24PoleMotorMechanicalSpeed => "Divide by 12 (24-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy13_26PoleMotorMechanicalSpeed => "Divide by 13 (26-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy14_28PoleMotorMechanicalSpeed => "Divide by 14 (28-pole motor mechanical speed)",
                Mct8329AFGDivFactor.DivideBy15_30PoleMotorMechanicalSpeed => "Divide by 15 (30-pole motor mechanical speed)",
                _ => throw new NotSupportedException()
            };
    }
}
