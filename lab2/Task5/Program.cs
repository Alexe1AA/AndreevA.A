using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;
using Task5.Utility;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
			ArrayMethods.FillingArray(arr);
			ArrayMethods.Print(arr);
            arr = ArrMethods.DelNegative(arr);
            ArrayMethods.Print(arr);
            Console.ReadLine();

        }
    }
}
