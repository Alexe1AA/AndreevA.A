using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;
namespace Task5.Utility
{
	class ArrMethods
	{
		public static int[] DelNegative(int[] arr)
		{
			int size = 0;
			int count = 0;

			size = arr.Length - ArrayMethods.CountingNegative(arr);

			int[] arr1 = new int[size];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > 0)
				{
					arr1[count] = arr[i];
					count++;
				}
			}
			return arr1;
		}
	}
}
