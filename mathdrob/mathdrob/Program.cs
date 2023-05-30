using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("введите 2 числа: x, y");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());

double st1;
double st2;
double st3;
double a;

st1 = Math.Pow(y, 2)+Math.Sin(x)/Math.Tan(y)+Math.Cos(x);
st2 = Math.Pow(y,3)+Math.Sin(x)/1+Math.Pow(Math.Cos(x*x),2);
st3 = Math.Pow(y, 4) + Math.Sin(x) / Math.Pow(Math.Tan(y), -1) + Math.Pow(Math.Cos(x * x * x), 3);

a= st1 - st2 + st3;
Console.WriteLine(a);
