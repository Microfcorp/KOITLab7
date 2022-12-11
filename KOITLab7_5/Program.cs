using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOITLab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 0.0001;
            double s = 0;
            double i = 1;

            double k = 0;
            while ((0.75 - s) > e)
            {
                k = 1 / (i * (i + 2));
                s = s + k;
                i = i + 1;
            }
            Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("Сравнивая с");
            Console.WriteLine(0.75);
            Console.ReadKey();
        }

        static double input(string txt = "")
        {
            Console.Write(txt.Trim() + " ");
            return double.Parse(Console.ReadLine());
        }
    }
}
