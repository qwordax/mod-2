using Distribution.Generators;
using System;

namespace Distribution.Algorithms
{
    public class Triangle : IDistributable
    {
        private IRandomable R { get; set; }

        private Double A { get; set; }
        private Double B { get; set; }

        public Triangle(IRandomable r, Double a, Double b)
        {
            R = r;
            A = a;
            B = b;
        }

        public Double Next()
        {
            Double r0 = (Double)R.Next() / UInt64.MaxValue;
            Double r1 = (Double)R.Next() / UInt64.MaxValue;

            return A + (B - A) * Math.Min(r0, r1);
        }
    }
}
