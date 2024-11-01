using AreaCalculation;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CheckSidesAreValid_ValidValuesForSides_ReturnsTrue()
        {
            //arrange
            //act
            bool sidesAreValid = Triangle.CheckSidesAreValid(50, 43, 69);
            //assert
            Assert.That(sidesAreValid, Is.True);
        }

        [Test]
        public void CheckSidesAreValid_InvalidSides_ThrowsException()
        {
            //arrange
            //act

            //assert
            Assert.Throws<ArgumentException>(() => new Triangle(2, 3, 80)); ;
        }

        [Test]
        public void CalculateArea_ValidValuesForSides_ReturnsArea()
        {
            //arrange
            var triangle = new Triangle(5, 5, 6);
            //act
            double area = triangle.Area;

            //assert
            Assert.That(area, Is.EqualTo(12));
        }

        [Test]
        public void CalculateArea_RightAngledTriangle_ReturnsArea()
        {
            //arrange

            //act
            double area = Triangle.CalculateArea(3, 4, 5);

            //assert
            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            //arrange

            //act
            bool isRightAngled = Triangle.IsRightAngled(3, 4, 5);

            //assert
            Assert.That(isRightAngled, Is.True);
        }
    }
}
