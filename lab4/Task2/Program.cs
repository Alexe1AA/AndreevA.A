using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mass = new int[]{1,2,5,2,5,5};
			int[] mass1 = new int[] {5, 4, 3, 2, 15, 11 };			
			Func<int, int, bool> predicate = (i, j) => i != j;
			DynamicArray<int> obj = new DynamicArray<int>(mass);
			DynamicArray<int> obj2 = new DynamicArray<int>(mass);
			obj.NotifyChanged += DisplayMessage;

			foreach (var item in obj)
			{
				Console.Write($"{item} ");
			}

			Console.WriteLine();
			foreach (var item in obj2)
			{
				Console.Write($"{item} ");
			}

			if (obj == obj2)
			{
				Console.WriteLine("Массивы одинаковы");
			}
			
			Console.WriteLine();
			obj2.Remove(3);
			obj.AddRange(mass1);
			obj.Insert(27, 10);			
			foreach (var item in obj2)
			{
				Console.Write($"{item} ");
			}			
			Console.ReadLine();			
			

		}
		public static void DisplayMessage(object obj, CapacityEventArgs arg)
		{
			Console.WriteLine($"OldCapacity {arg.OldCapacity}  NewCapacity {arg.NewCapacity}");
			
		}
	}
	
}
