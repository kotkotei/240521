using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//6.50. Дано натуральное число. Верно ли, что в нем нет цифры b?
            Console.WriteLine("введите число = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int b = 3, i = 0;
            while (x != 0)
            {
                if (x % 10 == b)
                {
                    i++;
                    Console.WriteLine("В числе есть цифра " + b);
                    break;
                }

                if (i == 0) Console.WriteLine("В числе отсутствует цифра " + b);
                break;
            }
            Console.ReadKey();



        }
    }
}
