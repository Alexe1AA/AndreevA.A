using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Class
{
	public static class Utility
	{
		public static void WriteLine(this List<string> list)
		{
			foreach(var item in list)
			{
				Console.Write($"{item }");
				Console.WriteLine();
			}
			Console.WriteLine();
		}

	}
}
