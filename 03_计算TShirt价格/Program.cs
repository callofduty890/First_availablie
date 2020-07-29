using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_计算TShirt价格
{
    class Program
    {
        static void Main(string[] args)
        {
            int T_Shirt = 35;
            int Trousers = 120;
            int totalMoney = 3 * T_Shirt + 2 * Trousers;
            Console.WriteLine(totalMoney);
            Console.ReadKey();
        }
    }
}
