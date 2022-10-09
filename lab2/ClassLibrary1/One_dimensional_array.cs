using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility1Lab2
{
    public static class One_dimensional_array_methods
    {
        public static void FillingInTheInterval(int[] arr, int Left, int right)
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomGenerator.Next(Left, right);
            }
        }

        public static void Filling(int[] arr,string Switch)
        {
            Random randomGenerator = new Random();
            switch (Switch)
            {
                case "Random":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = randomGenerator.Next(-60, 60);
                    }
                    break;
                case "Console":
                    string Input;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine("Input " + (i+1) + " element");
                        Input = Console.ReadLine();
                        if (!(int.TryParse(Input, out arr[i])))
                        {
                            Console.WriteLine("the wrong type of element");
                            break;
                        }
                    }
                    break;
            }
            
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void BubbleSort(int[] arr, string Switch)
        {
            int Swap;            
            switch(Switch)
            {
                case "Up":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr.Length - 1; j++)
                        {
                            if (arr[j] > arr[j + 1])
                            {
                                Swap = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = Swap;
                            }
                        }
                    }                    
                    break;
                case "Down":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr.Length - 1; j++)
                        {
                            if (arr[j] < arr[j + 1])
                            {
                                Swap = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = Swap;
                            }
                        }
                    }                    
                    break;

            }            
                        
        }
        public static void Max(int[] arr)
        {
            int Max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            Console.WriteLine("Max = " + Max);
        }
        public static void Min(int[] arr)
        {
            int Min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            Console.WriteLine("Min = " + Min);
        }
        public static void Summ(int[] arr)
        {
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Sum += arr[i];
                }
            }
            Console.WriteLine("Sum = " + Sum);
        }
        public static int[] Delete_negative_elements(int[] arr)
        {            
            int N = 0;
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    N += 1;
                }
            }
            int[] arr1 = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr1[k]= arr[i];
                    k++;
                }
            }
            return arr1;
        }
        public static int[] Doubling_of_negative_elements(int[] arr)
        {
            int N = 0;
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    N += 1;
                }
            }
            int[] arr1 = new int[arr.Length+N];
            for (int i = 0; i < arr.Length; i++)
            {                
                if (arr[i] < 0)
                {
                    arr1[k] = arr[i];
                    arr1[k+1] = arr[i];
                    k += 2;
                }
                else
                {
                    arr1[k] = arr[i];
                    k++;
                }
            }
            return arr1;

        }
        public static void Search(int[] arr,int Number)
        {
            bool Flag = true; 
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==Number)
                {
                    Flag = false;
                    Console.WriteLine("Pos== " + i);
                }
            }
            if(Flag)
            {
                Console.WriteLine();
                Console.WriteLine(" there are no such elements");
            }

        }
        public static bool Check(int[] arr1,int[] arr2)
        {
            bool Flag = true;
            One_dimensional_array_methods.BubbleSort(arr1, "Up");
            One_dimensional_array_methods.BubbleSort(arr2, "Up");
            for (int i = 0; i < arr1.Length; i++)
            {                
                if(arr1[i]==arr2[i])
                {
                    Flag = true;
                }
                else
                {
                    Flag = false;
                    break;
                }

            }
            return Flag;
        }
    }
    
}
