using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
	class Task_7
	{
		private int[] array = { 4, 89, 75, 382, 49, 1 };

		private int sumEven = 0;
		private int sumNoEven = 0;

		private int EvenIndexArgsSum()
		{
			int sumOfEvenIndexElements = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (i % 2 == 0)
				{
					sumOfEvenIndexElements += array[i];
				}
			}
			sumEven = sumOfEvenIndexElements;
			return sumOfEvenIndexElements;
		}

		private int NoEvenIndexArgsSum()
		{
			int sumOfNoEvenIndexElements = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (i % 2 != 0)
				{
					sumOfNoEvenIndexElements += array[i];
				}
			}
			sumNoEven = sumOfNoEvenIndexElements;
			return sumOfNoEvenIndexElements;
		}

		public void WhatSumIsBigger()
		{
			EvenIndexArgsSum();
			NoEvenIndexArgsSum();
			if (sumEven > sumNoEven)
			{
				Console.WriteLine("True");
			} 
			else if (sumEven < sumNoEven)
			{
				Console.WriteLine("False");
			}
			else
			{
				throw new Exception("Суммы равны");
			}
		}
	}
}
