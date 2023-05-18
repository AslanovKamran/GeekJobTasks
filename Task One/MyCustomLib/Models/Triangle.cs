using MyCustomLib.Abstarct;

namespace MyCustomLib.Models
{
	public class Triangle : IMeasurableFigure
	{
		public double Side_A { get; set; }
		public double Side_B { get; set; }
		public double Side_C { get; set; }

		public Triangle(double side_A, double side_B, double side_C)
		{
			//The triangle rule:
			//The sum of two side lengths has to exceed the length of the third side.
			//If the rule is drawn, an error is thrown
			if (side_A >= side_B + side_C ||
			   side_B >= side_A + side_C ||
			   side_C >= side_A + side_B)
			{
				throw new ArgumentException(message: "ERROR!\nEach side length must be less than the length sum of the others");
			}

			//Avoiding the negative side values
			Side_A = Math.Abs(side_A);
			Side_B = Math.Abs(side_B);
			Side_C = Math.Abs(side_C);
		}

		public double GetFigureArea()
		{
			//Heron's formula to calculate the triangle area by its sides
			//√[s(s-a)(s-b)(s-c)]
			//Where: s is the semi perimeters; a, b, c are the sides of the triangle

			var semiPerimeter = (Side_A + Side_B + Side_C) / 2;
			var area = Math.Sqrt(semiPerimeter * (semiPerimeter - Side_A) * (semiPerimeter - Side_B) * (semiPerimeter - Side_C));
			return Math.Round(area, 2);
		}

		public bool IsRectangular()
		{
			//A triangle is rectangular if Pythagoras' theorem is true for it
			//Theorem : the square of the hypotenuse is equal to the sum of the squares of the other two sides

			double hypotenuse = Side_C;
			double firstSide = Side_A;
			double secondSide = Side_B;

			if (Side_A > Side_B && Side_A > Side_C) { hypotenuse = Side_A; firstSide = Side_B; secondSide = Side_C; }
			else if (Side_B > Side_C && Side_B > Side_A) { hypotenuse = Side_B; firstSide = Side_A; secondSide = Side_C; }

			return Math.Pow(hypotenuse, 2) == (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2));
		}

		public string GetInfo() => $"{this.GetType().Name} with Sides {Side_A}, {Side_B}, {Side_C} cm. (Is Rectangular : {IsRectangular()})";

	}
}
