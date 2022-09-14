using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class RightTriangle : IShape
    {
        public double Hyputenuse { get; init; }
        public double A { get; init; }
        public double B { get; init; }

        public RightTriangle(double hyputenuse, double a, double b)
        {
            Hyputenuse = hyputenuse;
            A = a;
            B = b;
        }

        public double GetArea()
        {
            return A * B / 2;
        }
    }
}