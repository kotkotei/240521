using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//6.34. Найти 15 первых натуральных чисел, делящихся нацело на 19 и находящихся  в интервале, левая граница которого равна 100.


            int x = 100;
            int n = 0;
            while (n <= 15)
            {
                if ((x)%19==0)
            {
               n++;
                    Console.WriteLine(x);
            }
                x++;
            }
            Console.ReadKey();

                
                
        }
    }
}
