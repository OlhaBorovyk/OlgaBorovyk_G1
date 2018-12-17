using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
	class Program
	{
		static void Main(string[] args)
		{
			//Задание 1
			Perimeter perimeter = new Perimeter();

			Console.WriteLine("1 - square");
			Console.WriteLine("2 - rectangle");
			Console.WriteLine("3 - triangle");
			Console.WriteLine();
			Console.WriteLine("Please, enter the number of shape:");
			var shapeNumber = Console.ReadLine();

			//square
			if (shapeNumber == "1")
			{
				Console.WriteLine("Enter the side lenght of your square:");
				var side = Console.ReadLine();
				int i = 0;
				Int32.TryParse(side, out i);
				var squarePerimeter = perimeter.GetPerimeter(i);
				Console.WriteLine($"Square perimeter - {squarePerimeter}");
				Console.ReadKey();
			}

			//rectangle
			else if (shapeNumber == "2")
			{
				Console.WriteLine("Enter two sides of your rectangle:");
				Console.WriteLine("First side: ");
				var firstSide = Console.ReadLine();
				var i = 0;
				Int32.TryParse(firstSide, out i);
				Console.WriteLine("Second side: ");
				var secondSide = Console.ReadLine();
				var j = 0;
				Int32.TryParse(secondSide, out j);
				var rectanglePerimeter = perimeter.GetPerimeter(i, j);
				Console.WriteLine($"Rectangle perimeter - {rectanglePerimeter}");
				Console.ReadKey();
			}

			//triangle
			else if (shapeNumber == "3")
			{
				Console.WriteLine("Enter three sides of your triangle:");
				Console.WriteLine("First side: ");
				var firstSide = Console.ReadLine();
				var i = 0;
				Int32.TryParse(firstSide, out i);
				Console.WriteLine("Second side: ");
				var secondSide = Console.ReadLine();
				var j = 0;
				Int32.TryParse(secondSide, out j);
				Console.WriteLine("Third side: ");
				var thirdSide = Console.ReadLine();
				var k = 0;
				Int32.TryParse(thirdSide, out k);
				var trianglePerimeter = perimeter.GetPerimeter(i, j, k);
				Console.WriteLine($"Triangle perimeter - {trianglePerimeter}");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("You do not read the terms. Bye");
			}

			//Задание 2
			Counter counter = new Counter();
			counter.FizzBuzz();
			Console.ReadLine();
		}
	}
}
