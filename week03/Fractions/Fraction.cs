using System;

//Create a class to hold fraction. The class should be in its own file
public class Fraction
{
    //The class should have two attributes for the top and bottom numbers. Make sure the attributes are private.
    private int _topNum;
    private int _bottomNum;

    //Create the Constructors. 
    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int top)
    {
        _topNum = top;
        _bottomNum = 1;
    }

    public Fraction(int topNum, int bottomNum)
    {
        _topNum = topNum;
        _bottomNum = bottomNum;
    }

    //Create getters and setters for both the top and the bottom values.
    public string GetFractionString()
    {
        string text = $"{_topNum}/{_bottomNum}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNum / (double)_bottomNum;
    }

}