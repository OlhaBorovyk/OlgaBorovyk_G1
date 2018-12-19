using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
	static class SecondTask
	{
		public static int SumOfEvenArgs()
		{
			int[] arr = { 45, 6, 78, 34, 23, 2, 0, 56, 83, 3, 569, 76, 90 };
			int sumOfEvenArgs = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0)
				{
					sumOfEvenArgs += arr[i];
				}
			}
			return sumOfEvenArgs;
		}
	}
}
