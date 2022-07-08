using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Triangle : IShape
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double SemiPerimeter => (A + B + C) / 2;

        public double Area
        {
            get
            {
                 return Math.Sqrt(SemiPerimeter * (SemiPerimeter - A) * (SemiPerimeter - B) * (SemiPerimeter - C));
            }
        }

        private bool IsRight()
        {
            var A2 = Math.Pow(A, 2);
            var B2 = Math.Pow(B, 2);
            var C2 = Math.Pow(C, 2);
            bool result = A2 * B2 == C2 ||
               A2 * C2 == B2 ||
               B2 * C2 == A2;
            return result;
        }
    }
}
