using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOITLab7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new List<double> { 1, 2, 3, 4, 6, 5, 8, 9, 10 };
            double a = input("a = ");
            double b = input("b = ");
            double kol = 0;
            bool istrue = false;
            for (int i = 1; i < k.Count; i++) {
                if (k[i] < k[i - 1]) {
                    istrue = true;
                    break;
                }
            }
            if (!istrue)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");
            k.RemoveRange(k.IndexOf(a), k.Count - k.IndexOf(b));

            Console.WriteLine("k = ");
            k.ForEach(t => Console.Write(t + " "));

            Console.ReadKey();
        }

        static double input(string txt = "")
        {
            Console.Write(txt.Trim() + " ");
            return double.Parse(Console.ReadLine());
        }
    }
}
