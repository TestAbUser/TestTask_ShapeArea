using static System.Math;

namespace AreaCalculation
{
    public class Triangle : Shape
    {
        private readonly uint _sideA, _sideB, _sideC;

        public override double Area { get; }
        public bool RightAngled => IsRightAngled(_sideA, _sideB, _sideC);

        public Triangle(uint sideA, uint sideB, uint sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            Area = CalculateArea(_sideA, _sideB, _sideC);
        }

        public static double CalculateArea(uint sideA, uint sideB, uint sideC)
        {
            if (CheckSidesAreValid(sideA, sideB, sideC))
            {
                double halfPerimiter = (double)(sideA + sideB + sideC) / 2;
                double area = Sqrt(halfPerimiter * (halfPerimiter - sideA) * (halfPerimiter - sideB) * (halfPerimiter - sideC));
                return area;
            }
            return default;
        }

        public static bool IsRightAngled(uint sideA, uint sideB, uint sideC)
        {
            if (CheckSidesAreValid(sideA, sideB, sideC))
            {
                if (Pow(sideA, 2) + Pow(sideB, 2) == Pow(sideC, 2) ||
                    Pow(sideA, 2) + Pow(sideC, 2) == Pow(sideB, 2) ||
                    Pow(sideC, 2) + Pow(sideB, 2) == Pow(sideA, 2))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CheckSidesAreValid(uint sideA, uint sideB, uint sideC)
        {
            bool valid = default;
            if ((sideA + sideC > sideB) && (sideA + sideB > sideC) && (sideB + sideC > sideA))
            {
                valid = true;
            }
            else
            {
                throw new ArgumentException("One or more sides are invalid");
            }
            return valid;
        }
    }
}
