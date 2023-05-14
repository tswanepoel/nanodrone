namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AOLAccA1Extensions
    {
        public static string GetDescription(this Mct8329AOLAccA1 oLAccA1)
            => oLAccA1 != Mct8329AOLAccA1.NoLimit ? $"{oLAccA1.GetValue():F3} Hz/s" : "No limit";

        public static float GetValue(this Mct8329AOLAccA1 oLAccA1)
            => oLAccA1 switch
            {
                Mct8329AOLAccA1.Value5mHzps => .005f,
                Mct8329AOLAccA1.Value10mHzps => .01f,
                Mct8329AOLAccA1.Value25mHzps => .025f,
                Mct8329AOLAccA1.Value50mHzps => .05f,
                Mct8329AOLAccA1.Value100mHzps => .1f,
                Mct8329AOLAccA1.Value250mHzps => .25f,
                Mct8329AOLAccA1.Value500mHzps => .5f,
                Mct8329AOLAccA1.Value1000mHzps => 1f,
                Mct8329AOLAccA1.Value2500mHzps => 2.5f,
                Mct8329AOLAccA1.Value5000mHzps => 5f,
                Mct8329AOLAccA1.Value7500mHzps => 7.5f,
                Mct8329AOLAccA1.Value10000mHzps => 10f,
                Mct8329AOLAccA1.Value12500mHzps => 12.5f,
                Mct8329AOLAccA1.Value15000mHzps => 15f,
                Mct8329AOLAccA1.Value20000mHzps => 20f,
                Mct8329AOLAccA1.Value30000mHzps => 30f,
                Mct8329AOLAccA1.Value40000mHzps => 40f,
                Mct8329AOLAccA1.Value50000mHzps => 50f,
                Mct8329AOLAccA1.Value60000mHzps => 60f,
                Mct8329AOLAccA1.Value75000mHzps => 75f,
                Mct8329AOLAccA1.Value100000mHzps => 100f,
                Mct8329AOLAccA1.Value125000mHzps => 125f,
                Mct8329AOLAccA1.Value150000mHzps => 150f,
                Mct8329AOLAccA1.Value175000mHzps => 175f,
                Mct8329AOLAccA1.Value200000mHzps => 200f,
                Mct8329AOLAccA1.Value250000mHzps => 250f,
                Mct8329AOLAccA1.Value300000mHzps => 300f,
                Mct8329AOLAccA1.Value400000mHzps => 400f,
                Mct8329AOLAccA1.Value500000mHzps => 500f,
                Mct8329AOLAccA1.Value750000mHzps => 750f,
                Mct8329AOLAccA1.Value1000000mHzps => 1000f,
                _ => throw new NotSupportedException()
            };
    }
}
