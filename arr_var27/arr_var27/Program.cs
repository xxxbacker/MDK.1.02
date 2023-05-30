using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr_var27
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double h = 0;

            h = 26 / Math.Abs((34.06 - 33.81) * 4 / (6.84 / Math.Pow(28.57 - 25.15, 1 / 5)) - Math.Sqrt(3 + 4.2/0.1/((1/0.3-2.7)/4.12))) + 2/3*(21/4)+Math.Pow((1+Math.Pow(5,1/3))/3.5, 1/4);

            Console.WriteLine(Math.Round(h,2));

        }
    }
}
