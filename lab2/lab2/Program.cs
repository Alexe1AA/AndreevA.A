using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility1Lab2;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]arr = new int[20];
            One_dimensional_array_methods.Filling(arr,"Random");
            One_dimensional_array_methods.Print(arr);
            One_dimensional_array_methods.BubbleSort(arr,"Up");
            One_dimensional_array_methods.Print(arr);
            One_dimensional_array_methods.Max(arr);
            One_dimensional_array_methods.Min(arr);
            Console.ReadLine();
        }
    }
}
