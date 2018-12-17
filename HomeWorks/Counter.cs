using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
	class Counter
	{
		//Задание 2
		public void FizzBuzz()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 & i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i%5==0)
				{
					Console.WriteLine("Buzz");
				}
				else if (i%3==0 )
				{
					Console.WriteLine("Fizz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}

		//Задание 3
		public void ChangeVariables(ref int a, ref int b)
		{
			a = a + b;
			b = a - b;
			a = a - b;
		}
	}
}
