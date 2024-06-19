using FiguresLib;
using FiguresLib.Figures;

namespace FigurestTest;

public class Tests
{
    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * 25).Within(1e-10));
    }
    
    [Test]
    public void CircleInvalidRadiusTest()
    {
        var circle = new Circle(-5);
    }
    
    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.GetArea(), Is.EqualTo(6).Within(1e-10));
    }
    
    [Test]
    public void TriangleInvalidSidesTest()
    {
        var triangle = new Triangle(1, 2, 3);
    }

    [Test]
    public void TriangleRightAngledTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightAngled());
    }

    [Test]
    public void TriangleNotRightAngledTest()
    {
        var triangle = new Triangle(3, 3, 3);
        Assert.IsFalse(triangle.IsRightAngled());
    }

    [Test]
    public void ShapeFactoryCircleTest()
    {
        var shape = ShapeFactory.CreateShape(5);
        Assert.That(shape, Is.InstanceOf(typeof(Circle)));
        Assert.That(shape.GetArea(), Is.EqualTo(Math.PI * 25).Within(1e-10));
    }

    [Test]
    public void ShapeFactoryTriangleTest()
    {
        var shape = ShapeFactory.CreateShape(3, 4, 5);
        Assert.That(shape, Is.InstanceOf(typeof(Triangle)));
        Assert.That(shape.GetArea(), Is.EqualTo(6).Within(1e-10));
    }

    [Test]
    public void ShapeFactoryInvalidParametersTest()
    {
        var shape = ShapeFactory.CreateShape();
    }
}