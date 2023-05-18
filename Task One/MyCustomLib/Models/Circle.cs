using MyCustomLib.Abstarct;

namespace MyCustomLib.Models
{
	public class Circle : IMeasurableFigure
	{
		public double Radius { get; set; }

		//Avoiding the negative side values
		public Circle(double radius) => Radius = Math.Abs(radius);

		public double GetFigureArea()
		{
			//Getting the circle area using π × r^2 formula
			var area = Math.PI * Math.Pow(Radius, 2);
			return Math.Round(area, 2);
		}

		public string GetInfo() => $"{this.GetType().Name} with Radius {Radius} cm.";

	}
}
