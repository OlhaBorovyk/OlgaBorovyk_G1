using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
	class Perimeter
	{
		public int GetPerimeter(int side)
		{
			var squarePerimeter = side * 4;
			return squarePerimeter;
		}

		public int GetPerimeter(int firstSide, int secondSide)
		{
			var rectanglePerimeter = (firstSide + secondSide) * 2;
			return rectanglePerimeter;
		}

		public int GetPerimeter(int firstSide, int secondSide, int thirdSide)
		{
			var trianglePerimeter = firstSide + secondSide + thirdSide;
			return trianglePerimeter;
		}
	}
}
