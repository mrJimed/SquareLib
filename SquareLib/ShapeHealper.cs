using SquareLib.Shapes.Interfaces;

namespace SquareLib
{
    /// <summary>
    /// Класс-помощник
    /// </summary>
    public static class ShapeHealper
    {
        /// <summary>
        /// Вычисление площади фигуры без знания типа фигуры в compile-time.
        /// </summary>
        /// <param name="shape">Фигура.</param>
        /// <returns>Площадь фигуры.</returns>
        public static double CalcSquare(IShape shape)
        {
            return shape.CalcSquare();
        }
    }
}
