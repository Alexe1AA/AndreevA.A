using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Utility
{
	class ArrMethods
	{
		public static void Filling(int[,,] arr, int min = -60, int max = 60)
		{
			Random randomGenerator = new Random();

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					for (int k = 0; k < arr.GetLength(2); k++)
					{
						arr[i, j, k] = randomGenerator.Next(min, max);
					}

				}
			}
		}
		public static void Print(int[,,] arr)
		{
			if (arr.GetLength(0) == 0 && arr.GetLength(1) == 0 && arr.GetLength(2) == 0)
			{
				Console.WriteLine("Array is empty");
				return;
			}
			Console.WriteLine("Print");
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				Console.WriteLine();
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.WriteLine();
					for (int k = 0; k < arr.GetLength(2); k++)
					{
						Console.Write(arr[i, j, k] + " ");
					}

				}
			}
			Console.WriteLine();
		}
		public static void PositiveByZero(int[,,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					for (int k = 0; k < arr.GetLength(2); k++)
					{
						if (arr[i, j, k] > 0)
						{
							arr[i, j, k] = 0;
						}
					}

				}
			}
		}
	}
}
