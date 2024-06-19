namespace FiguresLib.Figures;

public class Triangle : IShape
{
    private double A { get; }
    private double B { get; }
    private double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Стороны должны быть больше нуля");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Данные стороны не образуют треугольника");

        A = a;
        B = b;
        C = c;
    }

    public double GetArea()
    {
        var s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
    
    public bool IsRightAngled()
    {
        double[] sides = [A, B, C];
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}
