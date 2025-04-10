// File: Square.cs

// This class represents a square and inherits from the Shape base class.
// It overrides GetArea to return the area of a square.
public class Square : Shape
{
    private float _side; // The length of the side of the square

    // Constructor sets the color and side length
    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    // Overrides the base method to calculate square area
    public override float GetArea()
    {
        return _side * _side;
    }
}
