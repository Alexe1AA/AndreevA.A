using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Utility
{
	class ArrMethods
	{
		public static int[] ItemPositionNumber(int[] arr, int Number)
		{
			bool Flag = true;
			int size = 0;
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == Number)
				{
					Flag = false;
					size += 1;					
				}
			}
			if (Flag)
			{				
				Console.WriteLine("there are no such elements");
				return new int[0];
			}
			else
			{
				int[] arr1 = new int[size];
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] == Number)
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
