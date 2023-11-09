public class Circle : Shape
{
    private double circleRadius;
    public Circle(string color, int radius) : base (color)
    {
        circleRadius = radius;
    }

    public override double GetArea()
    {
        return 2 * 3.14 * circleRadius;
    }
}