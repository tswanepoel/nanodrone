namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329AIpdRepeatExtensions
    {
        public static string GetDescription(this Mct8329AIpdRepeat ipdRepeat)
            => ipdRepeat switch
            {
                Mct8329AIpdRepeat.Once => "Once",
                Mct8329AIpdRepeat.AverageOf2Times => "Average of 2 times",
                Mct8329AIpdRepeat.AverageOf3Times => "Average of 3 times",
                Mct8329AIpdRepeat.AverageOf4Times => "Average of 4 times",
                _ => throw new NotSupportedException()
            };
    }
}
