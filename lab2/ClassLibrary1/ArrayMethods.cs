using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUtilitys
{
    public static class ArrayMethods
    {
        public static void FillingRandom(int[] arr, int min = -60, int max = 60)
        {			
			Random randomGenerator = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomGenerator.Next(min, max);
            }
        }  
		
        public static void Print(int[] arr)
        {
			if (arr.Length == 0)
			{
				Console.WriteLine("Array is empty");
				return;
			}
			for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

		public static bool FillingConsol(int[] arr)
		{
			if (arr.Length == 0)
			{				
				return false;
			}
			string input;
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("Input " + (i + 1) + " element");
				input = Console.ReadLine();
				if (!(int.TryParse(input, out arr[i])))
				{					
					return false;
				}
			}
			return true;
		}
		public static int CountingNegative(int[] arr)
		{			
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < 0)
				{
					count++;
				}
			}
			return count;

		}

	}
    
}
