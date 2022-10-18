using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;
namespace Task6.Utility
{
	class ArrMethods
	{
		public static int[] DoublNegative(int[] arr)
		{
			int size = 0;
			int k = 0;

			size = arr.Length + ArrayMethods.CountingNegative(arr);

			int[] arr1 = new int[size];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < 0)
				{
					arr1[k] = arr[i];
					arr1[k + 1] = arr[i];
					k += 2;
				}
				else
				{
					arr1[k] = arr[i];
					k++;
				}
			}
			return arr1;

		}
	}
}
