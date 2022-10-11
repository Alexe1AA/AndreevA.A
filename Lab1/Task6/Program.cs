using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double S = 0;

            string s1;
            string s2;
            string s3;

            Console.WriteLine("Input a");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            s3 = Console.ReadLine();
            if (double.TryParse(s1, out a) && double.TryParse(s2, out b) && double.TryParse(s3, out c))
            {
                if ((a + b > c) && (a + c > b) && (b + c > a))
                {                    
                    S = Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
                }
                else
                {
                    Console.WriteLine("the triangle does not exist");
                    Console.ReadLine();
                    return;
                }

            }
            else
            {
                Console.WriteLine("Error");                
            }
            Console.WriteLine("S== " + S);
            Console.ReadLine();
        }
    }
}
