public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(double Length, double Width, string Color)
    {
        _color = Color;
        _length = Length;
        _width = Width;
    }
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}