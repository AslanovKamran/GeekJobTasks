using MyCustomLib.Abstarct;

namespace MyCustomLib.Models
{
	public class Square : IMeasurableFigure
	{
		public double Side { get; set; }

		//Avoiding the negative side values
		public Square(double side) => Side = Math.Abs(side);

		public double GetFigureArea()
		{
			//Getting the square area using a × a formula 
			var area = Math.Pow(Side, 2);
			return Math.Round(area, 2);
		}

		public string GetInfo() => $"{this.GetType().Name} with Side {Side} cm.";
	}
}
