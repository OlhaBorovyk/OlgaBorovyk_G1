using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
	static class SortArray
	{
		public static int[] SortArrayMethod()
		{
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 3 };
			Array.Reverse(arr);
			return arr;
		}
	}
}
