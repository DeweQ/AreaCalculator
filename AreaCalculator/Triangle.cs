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

        public double Area
        {
            get
            {

                if (IsRight()) return GetAreaOfRightTriangle();
                return GetAreaOfAnyTriangle();

            }
        }

        private double GetAreaOfAnyTriangle()
        {
            double sp = SemiPerimeter;
            double result = Math.Sqrt(sp * (sp - A) * (sp - B) * (sp - C));
            return result;
        }

        // much more calculations than three sides formula. probably better without it
        private double GetAreaOfRightTriangle()
        {
            double result = 0;
            switch (FindHypotenuse())
            {
                case 'A':
                    result = B * C / 2;
                    break;
                case 'B':
                    result = A * C / 2;
                    break;
                case 'C':
                    result = A * B / 2;
                    break;
            }
            return result;
        }

        private char FindHypotenuse()
        {
            var A2 = Math.Pow(A, 2);
            var B2 = Math.Pow(B, 2);
            var C2 = Math.Pow(C, 2);
            if (A2 * B2 == C2)
                return 'C';
            if (A2 * C2 == B2)
                return 'B';
            return 'A';
        }

        private bool IsRight()
        {
            if (A == B && A == C)
                return false;
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
