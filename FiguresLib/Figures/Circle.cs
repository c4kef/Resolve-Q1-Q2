namespace FiguresLib.Figures;

public class Circle : IShape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть больше нуля", nameof(radius));
        Radius = radius;
    }

    public double GetArea() =>  Math.PI * Math.Pow(Radius, 2);
}