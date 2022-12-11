using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOITLab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = input("x = ");
            var y = input("y = ");
            if ((x > 1 || x < -2) || Math.Abs(y) > 1)
                Console.WriteLine("не принадлежит");
            else
                if((y >= x && (y <= 1 && y >= 0)) || Math.Pow((x + 1), 2) + Math.Pow(y, 2) <= 1)
                    Console.WriteLine("принадлежит");
                else
                    Console.WriteLine("не принадлежит");

            Console.ReadKey();
        }

        static double input(string txt = "")
        {
            Console.Write(txt.Trim() + " ");
            return double.Parse(Console.ReadLine());
        }
    }
}
