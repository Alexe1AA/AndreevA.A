using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "Monday monday Monday Tuesday tuesday Saturday June September ";
			var dictionary = Utility.FrequencyOfWords(text);
			foreach(var item in dictionary)
			{
				Console.WriteLine($"{item.Key} {item.Value}");
			}

			Console.ReadLine();
		}
	}
}
