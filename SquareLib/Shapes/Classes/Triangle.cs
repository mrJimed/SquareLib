using SquareLib.Shapes.Interfaces;

namespace SquareLib.Shapes.Classes
{
    /// <summary>
    /// Класс треугольник.
    /// </summary>
    public class Triangle : ITriangle
    {
        /// <summary>
        /// Сторона A.
        /// </summary>
        public double SideA { get; private set; }

        /// <summary>
        /// Сторона B.
        /// </summary>
        public double SideB { get; private set; }

        /// <summary>
        /// Сторона C.
        /// </summary>
        public double SideC { get; private set; }

        /// <summary>
        /// Конструктор, принимающий 3 стороны треугольника.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        /// <exception cref="ArgumentException">Возникает, если сторона треугольника меньше 0
        /// или сумма двух сторон меньше или равна третьей стороне</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны треугольника должны быть больше 0");
            else if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Сумма любых двух сторон должна быть больше третьей стороны");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        ///  Вычисляет площадь треугольника по 3-м сторонам.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double CalcSquare()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Проверяет является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsRightTriangle()
        {
            return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2) ||
                Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2) ||
                Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
        }
    }
}
