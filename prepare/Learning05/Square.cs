public class Square : Shape
{
    private double _side;
    public Square(double Side, string Color)
    {
        _color = Color;
        _side = Side;
    }
    public override double GetArea()
    {
        double area = Math.Pow(_side, 2);
        return area;
    }
}