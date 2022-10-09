using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility1Lab2;
namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            int N;
            Console.WriteLine("enter the size of the array");
            Input = Console.ReadLine();
            if (!(int.TryParse(Input, out N)))
            {
                Console.WriteLine("the wrong type of element");
                Console.ReadLine();
                return;
            }
            int[] arr = new int[N];
            int[] arr1 = new int[N];
            Console.WriteLine("Input array1");
            One_dimensional_array_methods.Filling(arr, "Console");
            Console.WriteLine("Input array2");
            One_dimensional_array_methods.Filling(arr1, "Console");
            if (One_dimensional_array_methods.Check(arr,arr1))
            {
                Console.WriteLine("these arrays are the same");
            }
            else
            {
                Console.WriteLine("these arrays are not the same");
            }            
            Console.ReadLine();
        }
    }
}
