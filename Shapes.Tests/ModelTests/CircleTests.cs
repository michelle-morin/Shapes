using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(4);

      // Act
      int result = newCircle.GetDiameter();

      // Assert
      Assert.AreEqual(result, 8);
    }

    [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(4);

      // Act
      double result = newCircle.GetCircumference();

      // Assert
      Assert.AreEqual(result, 25.13);
    }
  }
}