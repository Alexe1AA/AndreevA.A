﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUtilitys;
using Task9.Utility;
namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
			int size = 0;			
            Console.WriteLine("enter the size of the array");
            input = Console.ReadLine();
            if (!(int.TryParse(input, out size)))
            {
                Console.WriteLine("the wrong type of element");
                Console.ReadLine();
                return;
            }
            int[] arr = new int[size];
            int[] arr1 = new int[size];
            Console.WriteLine("Input array1");
            ArrayMethods.FillingConsol(arr);
            Console.WriteLine("Input array2");
            ArrayMethods.FillingConsol(arr1);
            if (ArrMethods.CompareArrays(arr,arr1))
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
