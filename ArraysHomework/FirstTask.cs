using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
	static class FirstTask
	{
		public static int FindMaxValueInArray()
		{
			int[] arr = { 24, 44, 99, 4287, 2341908, 4398, 0, 4793, 438, 1983 };
			int maxValue = arr.Max();
			return maxValue;
		}
	}
}
