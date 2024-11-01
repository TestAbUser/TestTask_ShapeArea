using AreaCalculation;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CalculateArea_ValidRadius_CalculatedArea()
        {
            //arrange
            Circle circle = new (8);
            //act
            //assert
            Assert.That(circle.Area, Is.EqualTo(Math.PI * 64));
        }
    }
}
