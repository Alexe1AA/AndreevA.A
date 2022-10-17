using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;
using lab2.utilitys;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]arr = new int[25];
            ArrayMethods.FillingArray(arr);
            ArrayMethods.Print(arr);
			ArrMethods.BubbleSort(arr);
            ArrayMethods.Print(arr);
            Console.WriteLine("Max = " + ArrMethods.GetMax(arr));
			Console.WriteLine("Min = " + ArrMethods.GetMin(arr));
            Console.ReadLine();
        }
    }
}
