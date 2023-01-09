using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public static class Utility
	{
		public static List<int> FillList(int n)
		{
			if (n < 0)
			{
				throw new ArgumentOutOfRangeException();
			}

			List<int> list = new List<int>();
			
			for(int i = 0; i < n;i++)
			{
				list.Add(i+1); 
			}

			return list;
		}

		public static List<int> ListOfDeleted(List<int> list)
		{
			List<int> dell = new List<int>();
			int current = 0;
			while (list.Count > 1)
			{
				current++;
				if (current >= list.Count)
				{
					current = 0;
				}
				dell.Add(list[current]);
				list.RemoveAt(current);
				if (current >= list.Count)
				{
					current = 0;
				}
			}

			return dell;
		}
	}
}
