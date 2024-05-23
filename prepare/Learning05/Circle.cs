public class Circle : Shape
{
    private double _radius;
    public Circle(double Radius, string Color)
    {
        _color = Color;
        _radius = Radius;
    }
    public override double GetArea()
    {
        double area = Math.Pow(_radius, 2) * Math.PI;
        return area;
    }
}