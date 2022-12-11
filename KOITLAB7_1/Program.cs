using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOITLAB7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = input("a = ");
            int b = input("b = ");
            int x = input("x = ");
            int y = input("y = ");

            var f = a * b * (x + y);

            Console.WriteLine(f);
            Console.ReadKey();
        }

        static int input(string txt = "")
        {
            Console.Write(txt.Trim() + " ");
            return int.Parse(Console.ReadLine());
        }
    }
}
