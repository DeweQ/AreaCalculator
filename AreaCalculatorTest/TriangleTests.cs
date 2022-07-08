using AreaCalculator;
using NUnit.Framework;

namespace AreaCalculatorTest
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [TestCase(5, 12, 13, 30)]
        [TestCase(1, 1, 1, 0.433)]
        [TestCase(4, 5, 6, 9.92)]
        public void TriangleArea_ShouldWork(double a,double b,double c, double expected)
        {
            Triangle triangle= new Triangle(a,b,c);

            double actual = triangle.Area;

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        [TestCase(0,0,0)]
        [TestCase(-1,-1,-1)]
        public void Triangle_ShouldFail(double a,double b,double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}
