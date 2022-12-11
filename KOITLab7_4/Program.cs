using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOITLab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1;
            double i = 1;

            double a = 0;
            while (i < 25)
            {
                a = Math.Pow(i, 2) / (Math.Pow(i, 2) + 2 * i + 3);
                sum = sum * a;
                i = i + 1;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static double input(string txt = "")
        {
            Console.Write(txt.Trim() + " ");
            return double.Parse(Console.ReadLine());
        }
    }
}
