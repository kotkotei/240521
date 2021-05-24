using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {//6.35. Найти 20 первых натуральных чисел, делящихся нацело на 13 или на 17 и находящихся в интервале, левая граница которого равна 500.

            int x = 500;
            int n = 0;
            while(n<20)
            {
                if ((x) %13 ==0 &&(x%17==0))
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
