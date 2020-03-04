using System;

namespace Shapes.Models
{
  public class Circle
  {
    public int Radius { get; set; }

    public Circle(int radius)
    {
      Radius = radius;
    }

    public int GetDiameter()
    {
      return Radius * 2;
    }

    public double GetCircumference()
    {
      return Math.Round((2 * Math.PI * Radius), 2);
    }
  }
}