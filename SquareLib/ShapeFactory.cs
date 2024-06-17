using SquareLib.Shapes.Interfaces;
using SquareLib.Shapes.Classes;

namespace SquareLib
{
    /// <summary>
    /// Фабрика для создания фигур.
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        /// Создаёт экземпляр класса треугольник, реализующего интерфейс ITriangle.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        /// <returns>Экземпляр класса треугольник, реализующего интерфейс ITriangle.</returns>
        public static ITriangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

        /// <summary>
        /// Создаёт экземпляр класса круг, реализующего интерфейс IShape.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Экземпляр класса круг, реализующего интерфейс IShape.</returns>
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }
    }
}
