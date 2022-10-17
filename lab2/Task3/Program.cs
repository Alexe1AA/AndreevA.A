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
            int[] arr = new int[10];
			ArrayMethods.FillingArray(arr);
			ArrayMethods.Print(arr);
			Console.WriteLine("Sum = " + ArrMethods.GetSum(arr));
            Console.ReadLine();
        }
    }
}
