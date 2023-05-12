namespace Biscuits.Devices.AlgorithmConfiguration.Extensions
{
    using System;

    public static class Mct8329ACommControlExtensions
    {
        public static string GetDescription(this Mct8329ACommControl commControl)
            => commControl switch
            {
                Mct8329ACommControl.Fixed120DegreeCommutation => "120 ° commutation",
                Mct8329ACommControl.VariableCommutationBetween120DegreesAnd150Degrees => "Variable commutation between 120 ° and 150 °",
                _ => throw new NotSupportedException()
            };
    }
}
