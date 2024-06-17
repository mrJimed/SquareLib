using SquareLib;

namespace SquareLibTests
{
    public class CircleTest
    {
        /// <summary>
        /// Проверяет работу метода CalcSquare на корректных данных.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        [Theory]
        [InlineData(1)]
        public void CalcSquare_CorrectResult(double radius)
        {
            var circle = ShapeFactory.CreateCircle(radius);
            Assert.Equal(circle.CalcSquare(), Math.PI * Math.Pow(radius, 2));
        }

        /// <summary>
        /// Проверяет работу метода CalcSquare на некорректных данных.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CalcSquare_ArgumentExceptionResult(double radius)
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(radius));
        }
    }
}