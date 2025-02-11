// Shape.cs - Base class for all shapes
public abstract class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
}