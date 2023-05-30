using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3_var27_chibisov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1");
            Console.WriteLine("введите 2 числа: x, y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите длину ряда");
            double n = Convert.ToDouble(Console.ReadLine());

            double st1 = 0;

            for (int i = 1;i <= n; i++)
            {
                if (i % 2 == 1)
                    st1 += Math.Pow(y, i + 1) + Math.Sin(x) / Math.Pow(Math.Tan(y), 2-i) + Math.Pow(Math.Cos(Math.Pow(x, i)), i);
                else
                    st1 -= Math.Pow(y, i + 1) + Math.Sin(x) / Math.Pow(Math.Tan(y), 2 - i) + Math.Pow(Math.Cos(Math.Pow(x, i)), i);

            }
            Console.WriteLine(Math.Round(st1,2));

            Console.WriteLine("задание 2");
            double a = 90;
            double delta = 10;

            Console.WriteLine("Угол\tЗначение sin\tЗначение cos");
            Console.WriteLine("---------------------------------");

            while (a <= 180)
            {
                double radians = a * Math.PI / 180;
                double sinValue = Math.Sin(radians);
                double cosValue = Math.Cos(radians);

                Console.WriteLine("{0}\t{1:F4}\t\t{2:F4}", a, sinValue, cosValue);

                a += delta;
            }

            Console.ReadLine();

        }
    }
}
