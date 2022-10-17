using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Utility
{
	class ArrMethods
	{
		public static bool CompareArrays(int[] arr1, int[] arr2)
		{
			bool Flag = true;
			if(arr1.Length == 0 || arr2.Length == 0)
			{
				Console.WriteLine("Array is empty");
				return false;
			}
			Array.Sort(arr1);
			Array.Sort(arr2);
			for (int i = 0; i < arr1.Length; i++)
			{
				if (arr1[i] == arr2[i])
				{
					Flag = true;
				}
				else
				{
					Flag = false;
					break;
				}
			}
			return Flag;
		}
	}
}
