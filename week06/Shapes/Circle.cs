// File: Circle.cs

using System;

// This class represents a circle and inherits from Shape.
// It uses the radius to calculate area using the formula πr².
public class Circle : Shape
{
    private float _radius; // The radius of the circle

    // Constructor sets the color and radius
    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    // Overrides the base method to calculate circle area
    public override float GetArea()
    {
        return (float)(Math.PI * _radius * _radius);
    }
}
