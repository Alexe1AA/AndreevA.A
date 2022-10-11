using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Summ = 0;
            int K = 1;
            for (int i = 3; i < 1000; i +=3 )
            {
                if(K!=5)
                {                    
                    Summ += i;
                    K++;
                }
                else
                {
                    K = 1;
                }
            }            
            for(int i = 0; i < 1000; i += 5 )
            {
                Summ += i;
            }
            Console.WriteLine(Summ);
            Console.ReadLine();
        }
    }
}
