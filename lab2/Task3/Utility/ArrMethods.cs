using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Utility
{
	class ArrMethods
	{
		public static int GetSumPositive(int[] arr)
		{
			int sum = 0;
			
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
