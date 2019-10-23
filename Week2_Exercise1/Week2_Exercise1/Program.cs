using System;

namespace _1A
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = d + d * 0.2;
            double f = b * 10;

            double g = e * c * b + f;

            Console.WriteLine("Total time needed to watch the {0} series is {1} minutes.", a, g);
        }
    }
}