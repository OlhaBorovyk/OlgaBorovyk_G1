using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
	class Program
	{
		static void Main(string[] args)
		{
			//Task 1
			var maxValue = FirstTask.FindMaxValueInArray();
			Console.WriteLine(maxValue);
			Console.ReadLine();

			//Task 2
			var sumOfEvenArgs = SecondTask.SumOfEvenArgs();
			Console.WriteLine(sumOfEvenArgs);
			Console.ReadLine();

			//Task 3
			var minValue = ThirdTask.FindMinInNoEvenArgs();
			Console.WriteLine(minValue);
			Console.ReadLine();

			//Task 4
			Console.WriteLine("Please, enter some word or sentence: ");
			var userString = Console.ReadLine();
			char[] arr = userString.ToCharArray();
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();

			//Task 5
			var arr1 = SortArray.SortArrayMethod();
			Console.WriteLine(string.Join(", ", arr1));
			Console.ReadLine();
		}
	}
}
