using System;

using Distribution.Generators;

namespace Distribution.Algorithms
{
    public class Gamma : IDistributable
    {
        private IRandomable R { get; set; }

        private Double Lambda { get; set; }
        private UInt64 Eta { get; set; }

        public Gamma(IRandomable r, Double lambda, UInt64 eta)
        {
            R = r;
            Lambda = lambda;
            Eta = eta;
        }

        public Double Next()
        {
            Double temp = 1.0;

            for (UInt32 i = 0; i < Eta; i++)
            {
                temp *= (Double)R.Next() / UInt64.MaxValue;
            }

            return -1.0 / Lambda * Math.Log(temp);
        }
    }
}
