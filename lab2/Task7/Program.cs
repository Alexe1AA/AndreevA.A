using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility1Lab2;

namespace Task7
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
            One_dimensional_array_methods.Filling(arr, "Console");
            One_dimensional_array_methods.Print(arr);
            One_dimensional_array_methods.BubbleSort(arr,"Down");
            One_dimensional_array_methods.Print(arr);
            Console.ReadLine();
        }
    }
}
