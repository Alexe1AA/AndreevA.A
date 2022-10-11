using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte A = 0;
            byte B = 0;
            string s1;
            string s2;
            Console.WriteLine("Input A");
            s1 = Console.ReadLine();
            Console.WriteLine("Input B");
            s2 = Console.ReadLine();
            if (!(byte.TryParse(s1, out A)&&byte.TryParse(s2, out B)))
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("and== " + (B & A));
            Console.WriteLine("or == " + (B | A));
            Console.WriteLine("xor== " + (B ^ A));
            Console.ReadLine();
        }
    }
}
