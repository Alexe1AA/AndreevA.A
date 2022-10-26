using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Utility;

namespace Task5
{
	class Program
	{
		static void Main(string[] args)
		{
			string str;
			Console.WriteLine("Введите текст, содержащий дату в формате dd-mm-yyyy:");
			str = Console.ReadLine();
			Console.WriteLine("Найденные даты:");
			StrMethods.PrintDates(StrMethods.DateCollection(str));
			Console.ReadLine();
		}
	}
}
