using System;

using Distribution.Generators;

namespace Distribution.Algorithms
{
    /// <summary>
    /// Represents a pseudorandom number generator based on
    /// the exponential distribution.
    /// </summary>
    public class Exponential : IDistributable
    {
        private IRandomable R { get; set; }

        private Double Lambda { get; set; }

        public Exponential(IRandomable r, Double lambda)
        {
            R = r;
            Lambda = lambda;
        }

        public Double Next()
        {
            Double r = (Double)R.Next() / UInt64.MaxValue;
            return -1 / Lambda * Math.Log(r);
        }
    }
}
