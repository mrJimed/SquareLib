using SquareLib;

namespace SquareLibTests
{
    public class CircleTest
    {
        /// <summary>
        /// ��������� ������ ������ CalcSquare �� ���������� ������.
        /// </summary>
        /// <param name="radius">������ �����.</param>
        [Theory]
        [InlineData(1)]
        public void CalcSquare_CorrectResult(double radius)
        {
            var circle = ShapeFactory.CreateCircle(radius);
            Assert.Equal(circle.CalcSquare(), Math.PI * Math.Pow(radius, 2));
        }

        /// <summary>
        /// ��������� ������ ������ CalcSquare �� ������������ ������.
        /// </summary>
        /// <param name="radius">������ �����.</param>
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CalcSquare_ArgumentExceptionResult(double radius)
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(radius));
        }
    }
}