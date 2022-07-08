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
            Radius = radius;
        }

        public double Area
        {
            get => Math.PI * Math.Pow(Radius, 2);
        }
    }
}
