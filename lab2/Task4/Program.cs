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
            int[,] arr = new int[0,0];
            ArrMethods.FillingArray(arr);
			ArrMethods.Print(arr);
			Console.WriteLine(ArrMethods.SumOfEvenPositions(arr));            
            Console.ReadLine();
        }
    }
}
