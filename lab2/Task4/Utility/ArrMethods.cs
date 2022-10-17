using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Utility
{
	class ArrMethods
	{
		public static void FillingArray(int[,] arr, int min = -60, int max = 60)
		{			
			Random randomGenerator = new Random();

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = randomGenerator.Next(min, max);
				}
			}
		}
		public static void Print(int[,] arr)
		{
			Console.Write("method Print");
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				Console.WriteLine();
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j] + " ");
				}
			}
			Console.WriteLine();
		}
		public static int SumOfEvenPositions(int[,] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				Console.WriteLine();
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if ((i + j) % 2 == 0)
					{
						sum += arr[i, j];
					}
				}
			}
			return sum;
		}
	}
}

