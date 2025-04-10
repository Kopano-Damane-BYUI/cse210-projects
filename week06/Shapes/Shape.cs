// File: Shape.cs

// This is the base abstract class for all shapes.
// It defines the common property "color" and an abstract method "GetArea".
public abstract class Shape
{
    private string _color; // The color of the shape

    public Shape(string color)
    {
        _color = color;
    }

    // Getter method to retrieve the color
    public string GetColor()
    {
        return _color;
    }

    // Setter method to change the color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method to be implemented by derived classes
    public abstract float GetArea();
}
