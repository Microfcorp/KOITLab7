using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOITLAB7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = input("a = ");
            double b = input("b = ");
            double x = input("x = ");
            double y = input("y = ");
            double z = input("z = ");

            double h;
            if (Math.Pow(Math.Abs(x), y) < z)
                h = x * x * x + Math.Abs(a) * Math.Sin(y);
            else
            {
                if(z <= Math.Pow(Math.Abs(x), y) && Math.Pow(Math.Abs(x), y) <= z + 10)
                    h = Math.Max(x, Math.Max(y, z));
                else
                    h = Math.Min(Math.Pow(x, 0.33), Math.Min(b * y, Math.Sqrt(Math.Abs(z))));
            }

            Console.WriteLine(h);
            Console.ReadKey();
        }

        static double input(string txt = "")
        {
            Console.Write(txt.Trim() + " ");
            return double.Parse(Console.ReadLine());
        }
    }
}
