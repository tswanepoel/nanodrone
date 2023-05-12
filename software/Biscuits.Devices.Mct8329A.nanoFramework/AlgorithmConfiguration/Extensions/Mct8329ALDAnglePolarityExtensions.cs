namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ALDAnglePolarityExtensions
    {
        public static string GetDescription(this Mct8329ALDAnglePolarity ldAnglePolarity)
            => ldAnglePolarity switch
            {
                Mct8329ALDAnglePolarity.Lag => "Lag",
                Mct8329ALDAnglePolarity.Lead => "Lead",
                _ => throw new NotSupportedException()
            };
    }
}
