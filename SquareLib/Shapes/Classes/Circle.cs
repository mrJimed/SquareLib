using SquareLib.Shapes.Interfaces;

namespace SquareLib.Shapes.Classes
{
    /// <summary>
    /// Класс круг.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Конструктор, принимающий радиус круга.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <exception cref="ArgumentException">Возникает, если радиус меньше или равен 0.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга по заданному радиусу.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double CalcSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
