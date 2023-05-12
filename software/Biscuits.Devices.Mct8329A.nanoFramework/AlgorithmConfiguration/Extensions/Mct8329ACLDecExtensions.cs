namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ACLDecExtensions
    {
        public static string GetDescription(this Mct8329ACLDec cLDec)
            => $"{cLDec.GetValue():F3} V/s";

        public static float GetValue(this Mct8329ACLDec cLDec)
            => cLDec switch
            {
                Mct8329ACLDec.Value5mVps => .005f,
                Mct8329ACLDec.Value10mVps => .01f,
                Mct8329ACLDec.Value25mVps => .025f,
                Mct8329ACLDec.Value50mVps => .05f,
                Mct8329ACLDec.Value100mVps => .1f,
                Mct8329ACLDec.Value250mVps => .25f,
                Mct8329ACLDec.Value500mVps => .5f,
                Mct8329ACLDec.Value1000mVps => 1f,
                Mct8329ACLDec.Value2500mVps => 2.5f,
                Mct8329ACLDec.Value5000mVps => 5f,
                Mct8329ACLDec.Value7500mVps => 7.5f,
                Mct8329ACLDec.Value10000mVps => 10f,
                Mct8329ACLDec.Value12500mVps => 12.5f,
                Mct8329ACLDec.Value15000mVps => 15f,
                Mct8329ACLDec.Value20000mVps => 20f,
                Mct8329ACLDec.Value30000mVps => 30f,
                Mct8329ACLDec.Value40000mVps => 40f,
                Mct8329ACLDec.Value50000mVps => 50f,
                Mct8329ACLDec.Value60000mVps => 60f,
                Mct8329ACLDec.Value75000mVps => 75f,
                Mct8329ACLDec.Value100000mVps => 100f,
                Mct8329ACLDec.Value125000mVps => 125f,
                Mct8329ACLDec.Value150000mVps => 150f,
                Mct8329ACLDec.Value175000mVps => 175f,
                Mct8329ACLDec.Value200000mVps => 200f,
                Mct8329ACLDec.Value250000mVps => 250f,
                Mct8329ACLDec.Value300000mVps => 300f,
                Mct8329ACLDec.Value400000mVps => 400f,
                Mct8329ACLDec.Value500000mVps => 500f,
                Mct8329ACLDec.Value750000mVps => 750f,
                Mct8329ACLDec.Value1000000mVps => 1_000f,
                Mct8329ACLDec.Value32767000mVps => 32_767f,
                _ => throw new NotSupportedException()
            };
    }
}
