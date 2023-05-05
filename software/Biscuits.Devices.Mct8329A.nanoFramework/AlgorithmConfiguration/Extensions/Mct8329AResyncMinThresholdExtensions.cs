using System;

namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    public static class Mct8329AResyncMinThresholdExtensions
    {
        public static string GetDescription(this Mct8329AResyncMinThreshold resyncMinThreshold)
            => resyncMinThreshold != Mct8329AResyncMinThreshold.MinDutyMultipliedByDCBusVoltage ? $"{resyncMinThreshold.GetValue() * 1_000f} mV" : "MIN_DUTY * DC_BUS_VOLTAGE";

        public static float GetValue(this Mct8329AResyncMinThreshold resyncMinThreshold)
            => resyncMinThreshold switch
            {
                Mct8329AResyncMinThreshold.Value300mV => 0.3f,
                Mct8329AResyncMinThreshold.Value400mV => 0.4f,
                Mct8329AResyncMinThreshold.Value500mV => 0.5f,
                Mct8329AResyncMinThreshold.Value600mV => 0.6f,
                Mct8329AResyncMinThreshold.Value800mV => 0.8f,
                Mct8329AResyncMinThreshold.Value1000mV => 1f,
                Mct8329AResyncMinThreshold.Value1250mV => 1.25f,
                _ => throw new NotSupportedException()
            };
    }
}
