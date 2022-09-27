using AreaCalculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorTest
{
    [TestFixture]
    public class IShapeTests
    {
        [Test]
        public void CalculatorCalculateArea_ShouldWork()
        {
            List<(IShape Shape,double Expected)> tesetCases = new List<(IShape, double)> 
            { 
                (new Circle(5),78.54),
                (new Circle(8),201.06),
                (new Circle(14),615.8),
                (new RightTriangle(12,7.2,9.6),34.56),
                (new RightTriangle(17,5.8,15.98),46.342),
                (new RightTriangle(21,9.9,18.52),91.674),
                (new Triangle(4,5,6),9.922),
                (new Triangle(15,6,13),38.68),
                (new Triangle(21,9.9,18.52),91.674),
            };

            foreach(var testCase in tesetCases)
            {
                AssertShape(testCase.Shape,testCase.Expected);
            }

        }
        private void AssertShape(IShape shape, double expected)
        {
            double actual = Calculator.CalculateArea(shape);

            Assert.AreEqual(expected, actual,0.1);
        }
    }
}