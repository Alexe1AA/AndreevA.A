using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int size;
            Console.WriteLine("enter the size of the array");
            input = Console.ReadLine();
            if (!(int.TryParse(input, out size)))
            {
                Console.WriteLine("the wrong type of element");
                Console.ReadLine();
                return;
            }
            int[] arr = new int[size];
            if(!ArrayMethods.FillingConsol(arr))
			{
				Console.WriteLine("Введен не тот тип");
				Console.ReadLine();
				return;
			}
            ArrayMethods.Print(arr);
			Array.Sort(arr);
			Array.Reverse(arr);
            ArrayMethods.Print(arr);
            Console.ReadLine();
        }
    }
}
