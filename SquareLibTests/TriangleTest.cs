
namespace SquareLib.Tests
{
    public class TriangleTest
    {
        /// <summary>
        /// Проверяет работу метода CalcSquare на корректных данных.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        [Theory]
        [InlineData(3, 4, 5)]
        public void CalcSquare_CorrectResult(double sideA, double sideB, double sideC)
        {
            var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            var p = (sideA + sideB + sideC) / 2;

            Assert.Equal(triangle.CalcSquare(), Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));
        }

        /// <summary>
        /// Проверяет работу метода CalcSquare на некорректных данных.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        [Theory]
        [InlineData(3, 4, 100)]
        [InlineData(-3, 4, 5)]
        [InlineData(-3, -4, 5)]
        [InlineData(-3, -4, -5)]
        public void CalcSquare_ArgumentExceptionResult(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(sideA, sideB, sideC));
        }

        /// <summary>
        /// Проверяет работу метода IsRightTriangle, если треугольник прямоугольный.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        [Theory]
        [InlineData(3, 4, 5)]
        public void IsRightTriangle_TrueResult(double sideA, double sideB, double sideC)
        {
            var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            Assert.True(triangle.IsRightTriangle());
        }

        /// <summary>
        /// Проверяет работу метода IsRightTriangle, если треугольник не прямоугольный.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        [Theory]
        [InlineData(3, 4, 2)]
        public void IsRightTriangle_FalseResult(double sideA, double sideB, double sideC)
        {
            var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            Assert.False(triangle.IsRightTriangle());
        }
    }
}
