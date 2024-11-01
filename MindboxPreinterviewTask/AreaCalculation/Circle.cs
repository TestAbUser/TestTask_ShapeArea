
namespace AreaCalculation
{
    public class Circle : Shape
    {
        private readonly uint _radius;
        public override double Area { get; }

        public Circle(uint radius)
        {
            _radius = radius;
            Area = CalculateArea(_radius);
        }

        public static double CalculateArea(uint radius)
        {
            double area =Math.PI*Math.Pow(radius, 2);
            return area;
        }
    }
}
