using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Utility;
namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			string str;
			Console.WriteLine("Введите строку");
			str = Console.ReadLine();
			if(StrMethods.IsPalindrom(str))
			{
				Console.WriteLine("Слово полиндром");
			}
			else
			{
				Console.WriteLine("Слово не является полиндромом");
			}
			Console.ReadLine();
		}
	}
}
