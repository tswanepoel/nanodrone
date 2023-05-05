﻿using System;

namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    public static class Mct8329AOLDutyExtensions
    {
        public static string GetDescription(this Mct8329AOLDuty olDuty)
            => $"{olDuty.GetValue() * 100f} %";

        public static float GetValue(this Mct8329AOLDuty olDuty)
            => olDuty switch
            {
                Mct8329AOLDuty.Value10Percent => .1f,
                Mct8329AOLDuty.Value15Percent => .15f,
                Mct8329AOLDuty.Value20Percent => .2f,
                Mct8329AOLDuty.Value25Percent => .25f,
                Mct8329AOLDuty.Value30Percent => .3f,
                Mct8329AOLDuty.Value40Percent => .4f,
                Mct8329AOLDuty.Value50Percent => .5f,
                Mct8329AOLDuty.Value100Percent => 1f,
                _ => throw new NotSupportedException()
            };
    }
}
