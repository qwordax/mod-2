using System;

using Distribution.Generators;

namespace Distribution.Algorithms
{
    public class Gauss : IDistributable
    {
        private IRandomable R { get; set; }

        private Double E { get; set; }
        private Double V { get; set; }

        private UInt64 N { get; set; }

        public Gauss(IRandomable r, Double e, Double v, UInt64 n)
        {
            R = r;
            E = e;
            V = v;
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
            temp *= V * Math.Sqrt(12.0 / N);

            return E + temp;
        }
    }
}
