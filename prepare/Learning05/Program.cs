using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green", 3);
        Rectangle rectangle = new Rectangle("red", 4, 2);
        Circle circle = new Circle("blue", 5);

        List<Shape> shapeHolder = new List<Shape>();
        shapeHolder.Add(square);
        shapeHolder.Add(rectangle);
        shapeHolder.Add(circle);

        foreach (Shape shape in shapeHolder)
        {
            string sColor = shape.GetColor();
            double sArea = shape.GetArea();
            Console.WriteLine($"The {sColor} {shape} has an area of {sArea}");


        }
    }
}