using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Utility;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
			const int size = 10;
			int[,] arr = new int[size, size];
            ArrMethods.FillingArray(arr);
			ArrMethods.Print(arr);
			Console.WriteLine(ArrMethods.SumOfEvenPositions(arr));            
            Console.ReadLine();
        }
    }
}
