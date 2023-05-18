using MyCustomLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresTests
{
    public class TriangleTests
    {
        [Fact]
        public void GetFigureArea_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double actualArea = triangle.GetFigureArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Fact]
        public void GetFigureArea_InvalidTriangle_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 2;
            double sideB = 3;
            double sideC = 10;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void IsRectangular_RectangularTriangle_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRectangular = triangle.IsRectangular();

            // Assert
            Assert.True(isRectangular);
        }

        [Fact]
        public void IsRectangular_NonRectangularTriangle_ReturnsFalse()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRectangular = triangle.IsRectangular();

            // Assert
            Assert.False(isRectangular);
        }

        [Fact]
        public void GetInfo_ReturnsCorrectInfoString()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            string expectedInfo = "Triangle with Sides 3, 4, 5 cm. (Is Rectangular : True)";

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            string actualInfo = triangle.GetInfo();

            // Assert
            Assert.Equal(expectedInfo, actualInfo);
        }
    }
}
