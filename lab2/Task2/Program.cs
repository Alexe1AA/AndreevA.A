using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility2Lab2;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[4,5,5];
            Three_dimensional_array_methods.Filling(arr);
            Three_dimensional_array_methods.Print(arr);
            Three_dimensional_array_methods.Replacement_by_zero(arr);
            Three_dimensional_array_methods.Print(arr);
            Console.ReadLine();
        }
    }
}
