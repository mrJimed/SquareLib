namespace SquareLib.Shapes.Interfaces
{
    public interface ITriangle : IShape
    {
        /// <summary>
        /// Проверяет является ли треугольник прямоугольным. 
        /// </summary>
        /// <returns>true/false.</returns>
        bool IsRightTriangle();
    }
}
