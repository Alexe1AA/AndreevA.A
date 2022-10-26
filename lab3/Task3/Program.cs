using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Utility;
namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{			
			string str;
			Console.WriteLine("Введите строку");
			str = Console.ReadLine();
			if (StrMethods.IsMail(str))
			{
				Console.WriteLine("Является адресом электронной почты");
			}
			else
			{
				Console.WriteLine("Не является адресом электронной почты");
			}
			Console.ReadLine();
		}
	}
}
