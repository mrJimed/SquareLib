using SquareLib;
using SquareLib.Shapes.Interfaces;

var shapes = new List<IShape>
{
    ShapeFactory.CreateCircle(1),
    ShapeFactory.CreateTriangle(4, 6, 8)
};

foreach(var shape in shapes)
    Console.WriteLine($"S = {ShapeHealper.CalcSquare(shape)}");