using AreaCalculator;
using NUnit.Framework;

namespace AreaCalculatorTest
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        [TestCase(6, 113.09)]
        [TestCase(0, 0)]
        [TestCase(1, Math.PI)]
        public void CircleArea_ShouldWork(double radius, double expected)
        {
            Circle circle = new Circle(radius);

            double actual = circle.Area;

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void Circle_ShouldFail()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
