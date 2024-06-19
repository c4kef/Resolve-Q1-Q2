using FiguresLib.Figures;

namespace FiguresLib;

public static class ShapeFactory
{
    public static IShape CreateShape(params double[] parameters)
    {
        if (parameters == null || parameters.Length == 0)
            throw new ArgumentException("В запросе отсутствуют параметры");

        return parameters.Length switch
        {
            1 => new Circle(parameters[0]),
            3 => new Triangle(parameters[0], parameters[1], parameters[2]),
            _ => throw new ArgumentException($"Данное кол-во параметров ({parameters.Length}) еще не поддерживается")
        };
    }
}