using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
	static class ThirdTask
	{
		public static int FindMinInNoEvenArgs()
		{
			int[] arr = { 2, 45, 59, 0, 4 };
			List<int> tmpList = new List<int>();

			for (int i = 0; i < arr.Length; i++)
			{
				if (i % 2 != 0)
				{
					tmpList.Add(arr[i]);
				}
			}
			int minValue = tmpList.Min();
			return minValue;
		}
	}
}
