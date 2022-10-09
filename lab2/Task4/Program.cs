using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility3Lab2;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3];
            Two_dimensional_array_methods.Filling(arr);
            Two_dimensional_array_methods.Print(arr);
            Two_dimensional_array_methods.Sum_of_even_positions(arr);            
            Console.ReadLine();
        }
    }
}
