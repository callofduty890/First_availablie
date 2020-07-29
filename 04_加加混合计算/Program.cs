using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_加加混合计算
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            //int b = a++ + ++a * 2 + --a + a++;

            int E = a++;
            Console.WriteLine("a:{0},E:{1}", a, E);

            int D = ++a;
            Console.WriteLine("a:{0},D:{1}", a, D);

            int F = --a;
            Console.WriteLine("a:{0},F:{1}", a, F);

            int G = a++;
            Console.WriteLine("a:{0},G:{1}", a, G);

            int b = E + D * 2 + F + G;

            Console.WriteLine("a:{0},b:{1}", a, b);
            Console.ReadKey();
        }
    }
}
