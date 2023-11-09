public class Rectangle : Shape
{
    private double sideLength1;
    private double sideLength2;
    public  Rectangle(string color, int side1, int side2) : base (color)
    {
        sideLength1 = side1;
        sideLength2 = side2;
    }

    public override double GetArea()
    {
        return sideLength1 * sideLength2;
    }
}