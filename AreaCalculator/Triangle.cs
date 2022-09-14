using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Triangle : IShape
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Sides of triangle must be more than 0");
            A = a;
            B = b;
            C = c;
        }

        private double SemiPerimeter => (A + B + C) / 2;

        private double CalculateArea()
        {
            double sp = SemiPerimeter;
            double result = Math.Sqrt(sp * (sp - A) * (sp - B) * (sp - C));
            return result;
        }

        /// <summary>
        /// Attempt to convert this triangle to Right Triangle.
        /// </summary>
        /// <param name="result">If succeeded, initialise new right triangle. Otherwise null.</param>
        /// <returns>Returns was attempt successful or not.</returns>
        public bool TryConvertToRightTriangle(out RightTriangle result)
        {
            result = null;
            if (A == B && A == C)
                return false;
            var sides = new[] { A, B, C };
            var hypotenuse = sides.Max();
            var legs = sides.Where(s => s != hypotenuse).ToArray();
            // if c^2 = a^2+b^2 triangle is right.
            if (Math.Pow(hypotenuse, 2) == legs.Select(l => Math.Pow(l, 2)).Sum())
            {
                result = new RightTriangle(hypotenuse, legs[0], legs[1]);
                return true;
            }
            return false;
        }

        public double GetArea()
        {
            if (TryConvertToRightTriangle(out RightTriangle rightTriangle))
            {
                return rightTriangle.GetArea();
            }
            return CalculateArea();
        }
    }
}
