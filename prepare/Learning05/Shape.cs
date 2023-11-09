public abstract class Shape
{
    private string shapeColor;

    public Shape(string color)
    {
        shapeColor = color;
    }

    public string GetColor()
    {
        return shapeColor;
    }

    public void SetColor(string color)
    {
        shapeColor = color;
    }

    public abstract double GetArea();
}