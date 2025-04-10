// File: Rectangle.cs

// This class represents a rectangle and inherits from Shape.
// It stores two sides and overrides GetArea.
public class Rectangle : Shape
{
    private float _length; // The length of the rectangle
    private float _width;  // The width of the rectangle

    // Constructor sets the color, length, and width
    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Overrides the base method to calculate rectangle area
    public override float GetArea()
    {
        return _length * _width;
    }
}
