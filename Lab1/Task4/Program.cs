using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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
                for (int i1 = 0; i1 < N; i1++)
                {
                    for (int i = 0; i <= i1; i++)
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
                    k = 1;                   
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
