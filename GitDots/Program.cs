using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, d, p, sSqr;

            var rand = new Random();

            x1 = rand.NextDouble() * 100;
            x2 = rand.NextDouble() * 100;
            y1 = rand.NextDouble() * 100;
            y2 = rand.NextDouble() * 100;

            d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            p = d * 4;

            sSqr = d * d;

            Console.WriteLine($"x1: {x1:F2} y1: {y1:F2}");
            Console.WriteLine($"x2: {x2:F2} y2: {y2:F2}");
            Console.WriteLine($"Длина отрезка: {d:F2}");
            Console.WriteLine($"Периметр квадрата: {p:F2}");
            Console.WriteLine($"Площадь квадрата: {sSqr:F2}");

            Console.ReadKey();
        }
    }
}
