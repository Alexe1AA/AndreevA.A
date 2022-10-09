using System;
using System.Collections.Generic;
using System.Text;

namespace Utility2Lab2
{
    public static class Three_dimensional_array_methods
    {
        public static void Filling(int[,,] arr)
        {
            Random randomGenerator = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i,j,k]= randomGenerator.Next(-60, 60);
                    }

                }
            }
        }
        public static void Print(int[,,] arr)
        {
            Console.Write("method Print");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i,j,k] + " ");
                    }

                }
            }
            Console.WriteLine();
        }
        public static void Replacement_by_zero(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if(arr[i,j,k] < 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }

                }
            }
        }
    }
}
