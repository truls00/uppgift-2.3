
using System;

namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många dagar ska du ha bilen?");
            double X = double.Parse(Console.ReadLine());

            Console.WriteLine("Och hur många kilometer ska du köra?");
            double Z = double.Parse(Console.ReadLine());

            double Y = X * 500 - 500;
            double m = Z * 1;

            double summa = m + Y + 300;

            Console.WriteLine("Den totala kostnaden blir " + summa);
            Console.ReadKey();

        }
    }
}

