using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsInterfaces
{
	class Ostrich : IHideHead, IBasicActions
	{
		public Ostrich()
		{
			Console.WriteLine("Hi! I'm ostrich!");
			Eat();
			Go();
			HideHead();
			Sleep();
		}

		public void Eat()
		{
			Console.WriteLine("I'm eating...");
		}

		public void Go()
		{
			Console.WriteLine("I'm going on...");
		}

		public void HideHead()
		{
			Console.WriteLine("I hide my head, when I'm scared!");
		}

		public void Sleep()
		{
			Console.WriteLine("zzzzz...");
		}
	}
}
