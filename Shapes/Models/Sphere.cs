using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Slice { get; set; }

    public Sphere(Circle circle)
    {
      Slice = circle;
    }

    public double GetVolume()
    {
      int radius = Slice.Radius;
      int radiusCubed = radius * radius * radius;
      double volume = 4 * Math.PI * radiusCubed / 3;
      return Math.Round(volume, 2);
    }

    public double GetSurfaceArea()
    {
      int radius = Slice.Radius;
      double surfaceArea = 4 * Math.PI * radius * radius;
      return Math.Round(surfaceArea, 2);
    }
  }
}