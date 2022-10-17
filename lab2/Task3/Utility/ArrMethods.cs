using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Utility
{
	class ArrMethods
	{
		public static int GetSum(int[] arr)
		{
			int sum = 0;
			if (arr.Length == 0)
			{
				Console.WriteLine("Array is empty");
				return 0;
			}
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > 0)
				{
					sum += arr[i];
				}
			}
			return sum;
		}
	}
}
