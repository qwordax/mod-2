using System;
using System.Collections.Generic;

namespace Distribution.Utilities
{
    /// <summary>
    /// Represents a class of computing mean.
    /// </summary>
    public static class Mean
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
