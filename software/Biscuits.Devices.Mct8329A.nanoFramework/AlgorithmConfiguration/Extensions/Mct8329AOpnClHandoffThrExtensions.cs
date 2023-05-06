namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AOpnClHandoffThrExtensions
    {
        public static string GetDescription(this Mct8329AOpnClHandoffThr opnClHandoffThr)
            => $"{opnClHandoffThr.GetValue()} Hz";

        public static float GetValue(this Mct8329AOpnClHandoffThr opnClHandoffThr)
            => opnClHandoffThr switch
            {
                Mct8329AOpnClHandoffThr.Value1Hz => 1f,
                Mct8329AOpnClHandoffThr.Value4Hz => 4f,
                Mct8329AOpnClHandoffThr.Value8Hz => 8f,
                Mct8329AOpnClHandoffThr.Value12Hz => 12f,
                Mct8329AOpnClHandoffThr.Value16Hz => 16f,
                Mct8329AOpnClHandoffThr.Value20Hz => 20f,
                Mct8329AOpnClHandoffThr.Value28Hz => 28f,
                Mct8329AOpnClHandoffThr.Value32Hz => 32f,
                Mct8329AOpnClHandoffThr.Value36Hz => 36f,
                Mct8329AOpnClHandoffThr.Value40Hz => 40f,
                Mct8329AOpnClHandoffThr.Value45Hz => 45f,
                Mct8329AOpnClHandoffThr.Value50Hz => 50f,
                Mct8329AOpnClHandoffThr.Value55Hz => 55f,
                Mct8329AOpnClHandoffThr.Value60Hz => 60f,
                Mct8329AOpnClHandoffThr.Value65Hz => 65f,
                Mct8329AOpnClHandoffThr.Value70Hz => 70f,
                Mct8329AOpnClHandoffThr.Value75Hz => 75f,
                Mct8329AOpnClHandoffThr.Value80Hz => 80f,
                Mct8329AOpnClHandoffThr.Value85Hz => 85f,
                Mct8329AOpnClHandoffThr.Value90Hz => 90f,
                Mct8329AOpnClHandoffThr.Value100Hz => 100f,
                Mct8329AOpnClHandoffThr.Value150Hz => 150f,
                Mct8329AOpnClHandoffThr.Value200Hz => 200f,
                Mct8329AOpnClHandoffThr.Value250Hz => 250f,
                Mct8329AOpnClHandoffThr.Value300Hz => 300f,
                Mct8329AOpnClHandoffThr.Value350Hz => 350f,
                Mct8329AOpnClHandoffThr.Value400Hz => 400f,
                Mct8329AOpnClHandoffThr.Value450Hz => 450f,
                Mct8329AOpnClHandoffThr.Value500Hz => 500f,
                Mct8329AOpnClHandoffThr.Value550Hz => 550f,
                Mct8329AOpnClHandoffThr.Value600Hz => 600f,
                _ => throw new NotSupportedException()
            };
    }
}
