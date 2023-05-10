namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mca8329ACLAccExtensions
    {
        public static string GetDescription(this Mca8329ACLAcc clAcc)
            => $"{clAcc.GetValue():F3} V/s";

        public static float GetValue(this Mca8329ACLAcc clAcc)
            => clAcc switch
            {
                Mca8329ACLAcc.Value5mVps => .005f,
                Mca8329ACLAcc.Value10mVps => .01f,
                Mca8329ACLAcc.Value25mVps => .025f,
                Mca8329ACLAcc.Value50mVps => .05f,
                Mca8329ACLAcc.Value100mVps => .1f,
                Mca8329ACLAcc.Value250mVps => .25f,
                Mca8329ACLAcc.Value500mVps => .5f,
                Mca8329ACLAcc.Value1000mVps => 1f,
                Mca8329ACLAcc.Value2500mVps => 2.5f,
                Mca8329ACLAcc.Value5000mVps => 5f,
                Mca8329ACLAcc.Value7500mVps => 7.5f,
                Mca8329ACLAcc.Value10000mVps => 10f,
                Mca8329ACLAcc.Value12500mVps => 12.5f,
                Mca8329ACLAcc.Value15000mVps => 15f,
                Mca8329ACLAcc.Value20000mVps => 20f,
                Mca8329ACLAcc.Value30000mVps => 30f,
                Mca8329ACLAcc.Value40000mVps => 40f,
                Mca8329ACLAcc.Value50000mVps => 50f,
                Mca8329ACLAcc.Value60000mVps => 60f,
                Mca8329ACLAcc.Value75000mVps => 75f,
                Mca8329ACLAcc.Value100000mVps => 100f,
                Mca8329ACLAcc.Value125000mVps => 125f,
                Mca8329ACLAcc.Value150000mVps => 150f,
                Mca8329ACLAcc.Value175000mVps => 175f,
                Mca8329ACLAcc.Value200000mVps => 200f,
                Mca8329ACLAcc.Value250000mVps => 250f,
                Mca8329ACLAcc.Value300000mVps => 300f,
                Mca8329ACLAcc.Value400000mVps => 400f,
                Mca8329ACLAcc.Value500000mVps => 500f,
                Mca8329ACLAcc.Value750000mVps => 750f,
                Mca8329ACLAcc.Value1000000mVps => 1_000f,
                Mca8329ACLAcc.Value32767000mVps => 32_767f,
                _ => throw new NotSupportedException()
            };
    }
}
