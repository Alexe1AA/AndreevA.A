using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            string s1;
            string s2;
            Console.WriteLine("Input a");
            s1 = Console.ReadLine();
            Console.WriteLine("Input b");
            s2 = Console.ReadLine();
            if (!(double.TryParse(s1, out a) && double.TryParse(s2, out b)))
            {
                Console.WriteLine("Введены недопустимые значения");
                Console.ReadLine();
                return;
            }
            if (a > 0 && b > 0)
            {
                System.Console.WriteLine("S== " + a * b);
            }
            else
            {
                Console.WriteLine("Длина не может быть отрицательной");
            }
            Console.ReadLine();
        }
    }
}
