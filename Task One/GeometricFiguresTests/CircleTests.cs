using MyCustomLib.Models;


namespace GeometricFiguresTests
{
    public class CircleTests
    {
        [Fact]
        public void GetFigureArea_ValidCircle_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * 25;

            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.GetFigureArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Fact]
        public void GetInfo_ReturnsCorrectInfoString()
        {
            // Arrange
            double radius = 5;
            string expectedInfo = "Circle with Radius 5 cm.";

            Circle circle = new Circle(radius);

            // Act
            string actualInfo = circle.GetInfo();

            // Assert
            Assert.Equal(expectedInfo, actualInfo);
        }
    }
}
