using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_计算圆的面积和周长
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, are, Perimeter;

            Console.WriteLine("请输入圆的半径:");
            r = Convert.ToDouble(Console.ReadLine());
            //面积
            are = Math.PI * r * r;
            //周长
            Perimeter = 2 * Math.PI * r;

            Console.WriteLine("半径为{0:0.00}的圆,面积为：{1:0.00} 周长{2:0.00}", r, are, Perimeter);

            Console.ReadKey();

        }
    }
}
