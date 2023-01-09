using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	public static class Utility
	{
		public static int SummElement(this int[] arr)
		{
			int summ = 0;
			for(int i =0; i< arr.Length; i++)
			{
				summ += arr[i];
			}
			return summ;
		}
	}
}
