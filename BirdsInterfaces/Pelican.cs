using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsInterfaces
{
	class Pelican : IBasicActions, ISwim, IFlying
	{
		public Pelican()
		{
			Console.WriteLine("Hi! I'm pelican!");
			Eat();
			Fly();
			FlyFast();
			Go();
			Sleep();
			Swim();
		}

		public void Eat()
		{
			Console.WriteLine("I like to eat fish.");
		}

		public void Fly()
		{
			Console.WriteLine("I'm flyiiiiing...");
		}

		public void FlyFast()
		{
			Console.WriteLine("I try, but I'm not fly too good((");
		}

		public void Go()
		{
			Console.WriteLine("I jump!");
		}

		public void Sleep()
		{
			Console.WriteLine("zzzz...");
		}

		public void Swim()
		{
			Console.WriteLine("I'm the one of those birds, who can swim!");
		}
	}
}
