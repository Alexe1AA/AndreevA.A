using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			const int n = 5;
			List<int> list = Utility.FillList(n);
			List<int> listDell = Utility.ListOfDeleted(list);
			Console.WriteLine("Список исключенных");
			foreach (var item in listDell)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
			Console.WriteLine($"Остался {list[0]}");

			Console.ReadLine();
		}

	}
}

