using MyCustomLib.Models;


namespace GeometricFiguresTests
{
    public class SquareTests
    {
        [Fact]
        public void GetFigureArea_ValidSquare_ReturnsCorrectArea()
        {
            // Arrange
            double side = 4;
            double expectedArea = 16;

            Square square = new Square(side);

            // Act
            double actualArea = square.GetFigureArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Fact]
        public void GetInfo_ReturnsCorrectInfoString()
        {
            // Arrange
            double side = 4;
            string expectedInfo = "Square with Side 4 cm.";

            Square square = new Square(side);

            // Act
            string actualInfo = square.GetInfo();

            // Assert
            Assert.Equal(expectedInfo, actualInfo);
        }
    }
}
