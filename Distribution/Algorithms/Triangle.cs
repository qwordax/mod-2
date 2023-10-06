﻿using System;

using Distribution.Generators;

namespace Distribution.Algorithms
{
    /// <summary>
    /// Represents a pseudorandom number generator based on
    /// the triangle distribution.
    /// </summary>
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
