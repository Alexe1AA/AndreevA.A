using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Utility;
namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			string str ;
			Console.WriteLine("Введите строку");
			str = Console.ReadLine();
			Console.WriteLine(StrMethods.DellTags(str));
			Console.WriteLine(StrMethods.DellTagsUseRegex(str));
			Console.ReadLine();
		}
	}
}
