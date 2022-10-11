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
            int N;            
            string s;
            Console.WriteLine("Input N");            
            s = Console.ReadLine();
            if (int.TryParse(s, out N))
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < i+1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();                    
                }
            }
            else
            {
                Console.WriteLine("Error");               
            }
            Console.ReadLine();
        }
    }
}
