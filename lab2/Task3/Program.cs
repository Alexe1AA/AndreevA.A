using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;
using Task3.Utility;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
			const int size = 10;
            int[] arr = new int[size];
			ArrayMethods.FillingRandom(arr);
			ArrayMethods.Print(arr);
			Console.WriteLine("Sum = " + ArrMethods.GetSum(arr));
            Console.ReadLine();
        }
    }
}
