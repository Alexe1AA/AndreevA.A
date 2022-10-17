using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;
using Task8.Utility;
namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int size;
			int number;
            Console.WriteLine("enter the size of the array");
            input = Console.ReadLine();
            if (!(int.TryParse(input, out size)))
            {
                Console.WriteLine("the wrong type of element");
                Console.ReadLine();
                return;
            }
			if(size == 0)
			{
				Console.WriteLine("array size 0");
				Console.ReadLine();
				return;
			}
            int[] arr = new int[size];
            Console.WriteLine("the occurrence of which element to find?");
            input = Console.ReadLine();
            if (!(int.TryParse(input, out number)))
            {
                Console.WriteLine("the wrong type of element");
                Console.ReadLine();
                return;
            }            
            ArrayMethods.FillingArray(arr, 0, 10);
            ArrayMethods.Print(arr);
			ArrayMethods.Print(ArrMethods.ItemPositionNumber(arr, number));			           
            Console.ReadLine();
        }
    }
}
