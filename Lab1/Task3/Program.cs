using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int k = 1;
            string s;
            Console.WriteLine("Input N");
            s = Console.ReadLine();
            if (int.TryParse(s, out N))
            {
                for (int i = 0; i < N; i++)
                {
                    for (int sp = i; sp < N - 1; sp++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < k; j++)
                    {

                        Console.Write("*");
                    }
                    Console.WriteLine();
                    k += 2;                   
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
