using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.utilitys
{
	class ArrMethods
	{
		public static void BubbleSort(int[] arr)
		{
			int Swap;
			bool flag = true;

			while (flag)
			{
				flag = false;
				for (int j = 0; j < arr.Length - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						Swap = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = Swap;
						flag = true;

					}
				}
			}

		}
		public static int GetMax(int[] arr)
		{
			if (arr.Length == 0)
			{				
				return 0;
			}
			int max = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			return max;

		}
		public static int GetMin(int[] arr)
		{
			if (arr.Length == 0)
			{				
				return 0;
			}
			int min = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}
			return min;
		}
	}
}
