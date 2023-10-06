using System;
using System.Collections.Generic;

namespace Distribution.Utilities
{
    /// <summary>
    /// Represents a class of computing variation.
    /// </summary>
    public static class Variation
    {
        public static Double Compute(List<Double> values)
        {
            Double result = 0.0;

            Double expect = Mean.Compute(values);

            foreach (Double value in values)
            {
                result += (value - expect) * (value - expect);
            }

            return result / values.Count;
        }
    }
}
