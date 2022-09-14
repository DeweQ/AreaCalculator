using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : IShape
    {
        public double Radius { get; init; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius of a circle must be more than 0");
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
