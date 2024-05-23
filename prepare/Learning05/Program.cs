using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(4, "Purple");
        Rectangle rect1 = new Rectangle(3, 4, "Orange");
        Circle circle1 = new Circle(5, "Chartruse");

        ListProperties(square1);
        ListProperties(rect1);
        ListProperties(circle1);

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(new Square(10, "Blue"));
        shapeList.Add(new Rectangle(8, 6, "Red"));
        shapeList.Add(new Circle(9, "Yellow"));

        ListProperties(shapeList[0]);
        ListProperties(shapeList[1]);
        ListProperties(shapeList[2]);
    }

    static void ListProperties(Shape shape1)
    {
        Console.WriteLine($"{shape1.GetType()}\n-------------------------");
        Console.WriteLine(shape1.GetColor());
        Console.WriteLine(shape1.GetArea());
        Console.WriteLine("-------------------------");
    }
}