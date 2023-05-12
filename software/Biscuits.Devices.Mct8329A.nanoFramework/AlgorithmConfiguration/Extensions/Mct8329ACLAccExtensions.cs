namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ACLAccExtensions
    {
        public static string GetDescription(this Mct8329ACLAcc cLAcc)
            => $"{cLAcc.GetValue():F3} V/s";

        public static float GetValue(this Mct8329ACLAcc cLAcc)
            => cLAcc switch
            {
                Mct8329ACLAcc.Value5mVps => .005f,
                Mct8329ACLAcc.Value10mVps => .01f,
                Mct8329ACLAcc.Value25mVps => .025f,
                Mct8329ACLAcc.Value50mVps => .05f,
                Mct8329ACLAcc.Value100mVps => .1f,
                Mct8329ACLAcc.Value250mVps => .25f,
                Mct8329ACLAcc.Value500mVps => .5f,
                Mct8329ACLAcc.Value1000mVps => 1f,
                Mct8329ACLAcc.Value2500mVps => 2.5f,
                Mct8329ACLAcc.Value5000mVps => 5f,
                Mct8329ACLAcc.Value7500mVps => 7.5f,
                Mct8329ACLAcc.Value10000mVps => 10f,
                Mct8329ACLAcc.Value12500mVps => 12.5f,
                Mct8329ACLAcc.Value15000mVps => 15f,
                Mct8329ACLAcc.Value20000mVps => 20f,
                Mct8329ACLAcc.Value30000mVps => 30f,
                Mct8329ACLAcc.Value40000mVps => 40f,
                Mct8329ACLAcc.Value50000mVps => 50f,
                Mct8329ACLAcc.Value60000mVps => 60f,
                Mct8329ACLAcc.Value75000mVps => 75f,
                Mct8329ACLAcc.Value100000mVps => 100f,
                Mct8329ACLAcc.Value125000mVps => 125f,
                Mct8329ACLAcc.Value150000mVps => 150f,
                Mct8329ACLAcc.Value175000mVps => 175f,
                Mct8329ACLAcc.Value200000mVps => 200f,
                Mct8329ACLAcc.Value250000mVps => 250f,
                Mct8329ACLAcc.Value300000mVps => 300f,
                Mct8329ACLAcc.Value400000mVps => 400f,
                Mct8329ACLAcc.Value500000mVps => 500f,
                Mct8329ACLAcc.Value750000mVps => 750f,
                Mct8329ACLAcc.Value1000000mVps => 1_000f,
                Mct8329ACLAcc.Value32767000mVps => 32_767f,
                _ => throw new NotSupportedException()
            };
    }
}
