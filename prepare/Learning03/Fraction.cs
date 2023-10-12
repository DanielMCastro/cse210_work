using System.Diagnostics;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        top = wholeNumber;
        bottom = 1;
    }
    public Fraction(int topNum, int bottomNum)
    {
        top = topNum;
        bottom = bottomNum;
    }

    /*
    public int GetTop()
    {
        return top;
    }
    public void SetTop(int fractionTop)
    {
        top = fractionTop;
    }
    public int GetBottom()
    {
        return bottom;
    }
    public void SetBottom(int fractionBottom)
    {
        bottom = fractionBottom;
    }
    */

    public string GetFractionString()
    {
        string fractionString = $"{top}" + "/" + $"{bottom}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double decimalValue = (double)top / (double)bottom;
        return decimalValue;
    }

}