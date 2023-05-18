
namespace MyCustomLib.Abstarct
{
	//Creating interface so that we can get the benefits of polymorphism
	//For example: calculating the area of a figure without knowing the type of it in compile-time

	public interface IMeasurableFigure
	{
		double GetFigureArea();
		string GetInfo();
	}
}
