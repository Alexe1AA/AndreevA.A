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
			const int size = 4;
            int[,,] arr = new int[size, size, size];
            ArrMethods.Filling(arr);
			ArrMethods.Print(arr);
			ArrMethods.PositiveByZero(arr);
			ArrMethods.Print(arr);
            Console.ReadLine();
        }
    }
}
