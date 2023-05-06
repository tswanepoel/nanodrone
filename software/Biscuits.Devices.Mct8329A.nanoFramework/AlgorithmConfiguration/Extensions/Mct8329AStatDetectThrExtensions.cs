namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AStatDetectThrExtensions
    {
        public static string GetDescription(this Mct8329AStatDetectThr statDetectThr)
            => $"{statDetectThr.GetValue() * 1_000f} mV";

        public static float GetValue(this Mct8329AStatDetectThr statDetectThr)
            => statDetectThr switch
            {
                Mct8329AStatDetectThr.Value5mV => .005f,
                Mct8329AStatDetectThr.Value10mV => .01f,
                Mct8329AStatDetectThr.Value15mV => .015f,
                Mct8329AStatDetectThr.Value20mV => .02f,
                Mct8329AStatDetectThr.Value25mV => .025f,
                Mct8329AStatDetectThr.Value30mV => .03f,
                Mct8329AStatDetectThr.Value50mV => .05f,
                Mct8329AStatDetectThr.Value100mV => .1f,
                _ => throw new NotSupportedException()
            };
    }
}
