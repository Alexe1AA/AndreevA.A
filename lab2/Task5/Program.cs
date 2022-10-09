using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility1Lab2;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            One_dimensional_array_methods.Filling(arr, "Random");
            One_dimensional_array_methods.Print(arr);
            arr = One_dimensional_array_methods.Delete_negative_elements(arr);
            One_dimensional_array_methods.Print(arr);
            Console.ReadLine();

        }
    }
}
