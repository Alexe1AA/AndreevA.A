using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4;
namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			string [] num ={"123","-122","qw11w"};
			
			for(int i = 0; i < num.Length; i++)
			{
				if(num[i].IsPositiveNumber())
				{
					Console.WriteLine($"{num[i]} положительное число");
				}
				else
				{
					Console.WriteLine($"{num[i]} Не число или отрицательное число");
				}
			}

			Console.ReadLine();
		}
	}
}
