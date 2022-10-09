using System;
using System.Collections.Generic;
using System.Text;

namespace Utility3Lab2
{
    public static class Two_dimensional_array_methods
    {
        public static void Filling(int[,] arr)
        {
            Random randomGenerator = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = randomGenerator.Next(-60, 60);
                }
            }
        }
        public static void Print(int[,] arr)
        {
            Console.Write("method Print");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
            }
            Console.WriteLine();
        }
        public static void Sum_of_even_positions(int[,] arr)
        {
            int Sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if((i + j) % 2 == 0)
                    {
                        Sum +=arr[i, j];                    
                    }
                }                
            }
            Console.WriteLine("Sum_of_even_positions = " + Sum);
        }
    }
}
