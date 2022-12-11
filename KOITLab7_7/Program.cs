using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOITLab7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = input("n = ");
            var a = new List<double>();
            double maxind = -100;
            var x = new List<double>();
            double k = 0;
            for (int i = 0; i < n; i++) {

                var b = new List<double>();
                for (int j = 0; j < n+1; j++)
                {
                    b.Add(input(""));
                    if (i == j) {
                        x.Add(b[j]);
                        if(maxind < x[(int)k])
                            maxind = x[(int)k];                       
                        k = k + 1;
                    }
                }
                a.AddRange(b.ToArray());
            }
            var y = new List<double>();
            for (int i = 0; i < n; i++)
            {
                if(x.Count > i)
                    y.Add(x[i] / maxind);
            }

            Console.WriteLine("a = ");
            a.ForEach(t => Console.Write(t + " "));
            Console.WriteLine();
            Console.WriteLine("x = ");
            x.ForEach(t => Console.Write(t + " "));
            Console.WriteLine();
            Console.WriteLine("y = ");
            y.ForEach(t => Console.Write(t + " "));
            Console.WriteLine();
            Console.ReadLine();
        }

        static double input(string txt = "")
        {
            Console.Write(txt.Trim() + " ");
            return double.Parse(Console.ReadLine());
        }
    }
}
