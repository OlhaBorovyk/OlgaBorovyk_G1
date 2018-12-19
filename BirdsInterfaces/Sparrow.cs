using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsInterfaces
{
	class Sparrow : IBasicActions, IFlying, IChirick
	{
		public Sparrow()
		{
			Console.WriteLine("Hi! I'm a sparrow");
			Chirick();
			Eat();
			Fly();
			FlyFast();
			Go();
			Sleep();
		}
		public void Chirick()
		{
			Console.WriteLine("It's my voice - chirick");
		}

		public void Eat()
		{
			Console.WriteLine("I like too eat bread");
		}

		public void Fly()
		{
			Console.WriteLine("I'm flying");
		}

		public void FlyFast()
		{
			Console.WriteLine("I'm flying so fast!");
		}

		public void Go()
		{
			Console.WriteLine("I jump");
		}

		public void Sleep()
		{
			Console.WriteLine("noooo...sleeep");
		}
	}
}
