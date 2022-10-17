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
            int[,,] arr = new int[4,5,5];
            ArrMethods.Filling(arr);
			ArrMethods.Print(arr);
			ArrMethods.PositiveByZero(arr);
			ArrMethods.Print(arr);
            Console.ReadLine();
        }
    }
}
