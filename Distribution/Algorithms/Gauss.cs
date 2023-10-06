using System;

using Distribution.Generators;

namespace Distribution.Algorithms
{
    /// <summary>
    /// Represents a pseudorandom number generator based on
    /// the Gauss distribution.
    /// </summary>
    public class Gauss : IDistributable
    {
        private IRandomable R { get; set; }

        private Double E { get; set; }
        private Double Sigma { get; set; }

        private UInt64 N { get; set; }

        public Gauss(IRandomable r, Double e, Double sigma, UInt64 n)
        {
            R = r;
            E = e;
            Sigma = sigma;
            N = n;
        }

        public Double Next()
        {
            Double temp = 0.0;

            for (UInt64 i = 0; i < N; i++)
            {
                temp += (Double)R.Next() / UInt64.MaxValue;
            }

            temp -= N / 2;
            temp *= Sigma * Math.Sqrt(12.0 / N);

            return E + temp;
        }
    }
}
