using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Utility;
namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			string str;
			Console.WriteLine("Введите строку");
			str = Console.ReadLine();
			Console.WriteLine("Средняя длина слова " + StrMethods.AverageWordLen(str));
			Console.ReadLine();
		}
	}
}
