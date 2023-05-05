using System;

namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    public static class Mct8329AOLAccExtensions
    {
        public static string GetDescription(this Mct8329AOLAcc olAcc)
            => olAcc != Mct8329AOLAcc.NoLimit ? $"{olAcc.GetValue()} Hz/s²" : "No limit";

        public static float GetValue(this Mct8329AOLAcc olAcc)
            => olAcc switch
            {
                Mct8329AOLAcc.Value5mHzps2 => 0.005f,
                Mct8329AOLAcc.Value10mHzps2 => 0.01f,
                Mct8329AOLAcc.Value25mHzps2 => 0.025f,
                Mct8329AOLAcc.Value50mHzps2 => 0.05f,
                Mct8329AOLAcc.Value100mHzps2 => 0.1f,
                Mct8329AOLAcc.Value250mHzps2 => 0.25f,
                Mct8329AOLAcc.Value500mHzps2 => 0.5f,
                Mct8329AOLAcc.Value1000mHzps2 => 1f,
                Mct8329AOLAcc.Value2500mHzps2 => 2.5f,
                Mct8329AOLAcc.Value5000mHzps2 => 5f,
                Mct8329AOLAcc.Value7500mHzps2 => 7.5f,
                Mct8329AOLAcc.Value10000mHzps2 => 10f,
                Mct8329AOLAcc.Value12500mHzps2 => 12.5f,
                Mct8329AOLAcc.Value15000mHzps2 => 15f,
                Mct8329AOLAcc.Value20000mHzps2 => 20f,
                Mct8329AOLAcc.Value30000mHzps2 => 30f,
                Mct8329AOLAcc.Value40000mHzps2 => 40f,
                Mct8329AOLAcc.Value50000mHzps2 => 50f,
                Mct8329AOLAcc.Value60000mHzps2 => 60f,
                Mct8329AOLAcc.Value75000mHzps2 => 75f,
                Mct8329AOLAcc.Value100000mHzps2 => 100f,
                Mct8329AOLAcc.Value125000mHzps2 => 125f,
                Mct8329AOLAcc.Value150000mHzps2 => 150f,
                Mct8329AOLAcc.Value175000mHzps2 => 175f,
                Mct8329AOLAcc.Value200000mHzps2 => 200f,
                Mct8329AOLAcc.Value250000mHzps2 => 250f,
                Mct8329AOLAcc.Value300000mHzps2 => 300f,
                Mct8329AOLAcc.Value400000mHzps2 => 400f,
                Mct8329AOLAcc.Value500000mHzps2 => 500f,
                Mct8329AOLAcc.Value750000mHzps2 => 750f,
                Mct8329AOLAcc.Value1000000mHzps2 => 1000f,
                _ => throw new NotSupportedException()
            };
    }
}
