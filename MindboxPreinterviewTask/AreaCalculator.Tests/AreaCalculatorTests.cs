using AreaCalculation;
using NUnit.Framework;
using static AreaCalculation.AreaCalculator;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        [Test]
        public void CalculateArea_ValidShape_ReturnCircleArea()
        {
            //arrange
            Circle circle = new(8);
            //act

            //assert
            Assert.That(CalculateArea(circle), Is.EqualTo(Math.PI * 64));
        }

        [Test]
        public void CalculateArea_ValidShape_ReturnTriangleArea()
        {
            //arrange
            var triangle = new Triangle(5, 5, 6);
            //act

            //assert
            Assert.That(CalculateArea(triangle), Is.EqualTo(12));
        }
    }
}
