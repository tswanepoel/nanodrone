namespace Biscuits.Devices.GateDriverConfiguration.Extensions
{
    using System;

    public static class Mct8329ASelVdsLvlExtensions
    {
        public static string GetDecription(this Mct8329ASelVdsLvl selVdsLvl)
            => $"{GetValue(selVdsLvl) * 1_000f} V";

        public static float GetValue(this Mct8329ASelVdsLvl selVdsLvl)
            => selVdsLvl switch
            {
                Mct8329ASelVdsLvl.Value60mV => .06f,
                Mct8329ASelVdsLvl.Value120mV => .12f,
                Mct8329ASelVdsLvl.Value180mV => .18f,
                Mct8329ASelVdsLvl.Value240mV => .24f,
                Mct8329ASelVdsLvl.Value300mV => .3f,
                Mct8329ASelVdsLvl.Value360mV => .36f,
                Mct8329ASelVdsLvl.Value420mV => .42f,
                Mct8329ASelVdsLvl.Value480mV => .48f,
                Mct8329ASelVdsLvl.Value600mV => .6f,
                Mct8329ASelVdsLvl.Value800mV => .8f,
                Mct8329ASelVdsLvl.Value1000mV => 1f,
                Mct8329ASelVdsLvl.Value1200mV => 1.2f,
                Mct8329ASelVdsLvl.Value1400mV => 1.4f,
                Mct8329ASelVdsLvl.Value1600mV => 1.6f,
                Mct8329ASelVdsLvl.Value1800mV => 1.8f,
                Mct8329ASelVdsLvl.Value2000mV => 2f,
                _ => throw new NotSupportedException()
            };
    }
}
