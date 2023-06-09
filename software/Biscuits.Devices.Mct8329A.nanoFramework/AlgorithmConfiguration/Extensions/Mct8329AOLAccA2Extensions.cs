﻿namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AOLAccA2Extensions
    {
        public static string GetDescription(this Mct8329AOLAccA2 oLAccA2)
            => oLAccA2 != Mct8329AOLAccA2.NoLimit ? $"{oLAccA2.GetValue():F3} Hz/s²" : "No limit";

        public static float GetValue(this Mct8329AOLAccA2 oLAccA2)
            => oLAccA2 switch
            {
                Mct8329AOLAccA2.Value5mHzps2 => .005f,
                Mct8329AOLAccA2.Value10mHzps2 => .01f,
                Mct8329AOLAccA2.Value25mHzps2 => .025f,
                Mct8329AOLAccA2.Value50mHzps2 => .05f,
                Mct8329AOLAccA2.Value100mHzps2 => .1f,
                Mct8329AOLAccA2.Value250mHzps2 => .25f,
                Mct8329AOLAccA2.Value500mHzps2 => .5f,
                Mct8329AOLAccA2.Value1000mHzps2 => 1f,
                Mct8329AOLAccA2.Value2500mHzps2 => 2.5f,
                Mct8329AOLAccA2.Value5000mHzps2 => 5f,
                Mct8329AOLAccA2.Value7500mHzps2 => 7.5f,
                Mct8329AOLAccA2.Value10000mHzps2 => 10f,
                Mct8329AOLAccA2.Value12500mHzps2 => 12.5f,
                Mct8329AOLAccA2.Value15000mHzps2 => 15f,
                Mct8329AOLAccA2.Value20000mHzps2 => 20f,
                Mct8329AOLAccA2.Value30000mHzps2 => 30f,
                Mct8329AOLAccA2.Value40000mHzps2 => 40f,
                Mct8329AOLAccA2.Value50000mHzps2 => 50f,
                Mct8329AOLAccA2.Value60000mHzps2 => 60f,
                Mct8329AOLAccA2.Value75000mHzps2 => 75f,
                Mct8329AOLAccA2.Value100000mHzps2 => 100f,
                Mct8329AOLAccA2.Value125000mHzps2 => 125f,
                Mct8329AOLAccA2.Value150000mHzps2 => 150f,
                Mct8329AOLAccA2.Value175000mHzps2 => 175f,
                Mct8329AOLAccA2.Value200000mHzps2 => 200f,
                Mct8329AOLAccA2.Value250000mHzps2 => 250f,
                Mct8329AOLAccA2.Value300000mHzps2 => 300f,
                Mct8329AOLAccA2.Value400000mHzps2 => 400f,
                Mct8329AOLAccA2.Value500000mHzps2 => 500f,
                Mct8329AOLAccA2.Value750000mHzps2 => 750f,
                Mct8329AOLAccA2.Value1000000mHzps2 => 1000f,
                _ => throw new NotSupportedException()
            };
    }
}
