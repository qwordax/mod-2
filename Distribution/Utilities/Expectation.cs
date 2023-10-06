using System;
using System.Collections.Generic;

namespace Distribution.Utilities
{
    /// <summary>
    /// Represents a class of computing expectation.
    /// </summary>
    public static class Expectation
    {
        public static Double Compute(List<Double> values)
        {
            Double result = 0.0;

            foreach (Double value in values)
            {
                result += value;
            }

            return result / values.Count;
        }
    }
}
