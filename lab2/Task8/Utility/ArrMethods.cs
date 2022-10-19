using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Utility
{
	class ArrMethods
	{
		public static int[] ItemPositionNumber(int[] arr, int numder)
		{
			bool flag = true;
			int size = 0;
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == numder)
				{
					flag = false;
					size += 1;					
				}
			}
			if (flag)
			{				
				return new int[0];
			}
			else
			{
				int[] arr1 = new int[size];
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] == numder)
					{
						arr1[count] = i;
						count++;
					}
				}
				return arr1;
			}			
		}
	}
}
