public class Square : Shape
{
    private int sideLength;
    public Square(string color, int side) : base (color)
    {
        sideLength = side;
    }

    public override double GetArea()
    {
        return sideLength * sideLength;
    }
}