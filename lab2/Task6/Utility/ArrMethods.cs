using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Utility
{
	class ArrMethods
	{
		public static int[] DoublNegative(int[] arr)
		{
			int N = 0;
			int k = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < 0)
				{
					N += 1;
				}
			}
			int[] arr1 = new int[arr.Length + N];
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
