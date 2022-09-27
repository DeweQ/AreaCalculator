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
    public class RightTriangleTests
    {
        [Test]
        [TestCase(13,5,12,30)]
        [TestCase(26,10,24,120)]
        [TestCase(15,9,12,54)]
        public void RightTriangleArea_ShouldWork(double hypotenuse, double a, double b, double expected)
        {
            RightTriangle triangle = new RightTriangle(hypotenuse, a, b);

            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}