using MyCustomLib.Abstarct;
using MyCustomLib.Models;

List<IMeasurableFigure> figureList = new()
{
	//Adding the classes that implement the mentioned interface
	new Circle(2),
	new Triangle(3, 6, 5),
	new Square(4),
};

//Polymorphism allows to  use the same methods to obtain the different implementations
foreach (var figure in figureList)
	Console.WriteLine($"{figure.GetInfo()}\nArea = {figure.GetFigureArea()} cm^2.\n\n");


//Trying to create a wrong triangle (5 >= 1 + 2 meaning that such triangle can't exist)
try
{
	var wrongTriangle = new Triangle(2, 5, 1);
}
catch (Exception ex)
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine(ex.Message);
	Console.ResetColor();
}