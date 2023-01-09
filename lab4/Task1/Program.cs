using System;
using System.Collections.Generic;
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
			DateTime date = new DateTime(2025, 10, 25);
			User user = new User("Name", "Surname", "Login", date);
			string s = "login Федор Федоров aqq@inbox.ru 20-12-2022";
			Console.WriteLine(user.ToString());			
			user.SetFromLine(s);
			Console.WriteLine(user.ToString());
			Console.ReadLine();

		}
	}	
}
