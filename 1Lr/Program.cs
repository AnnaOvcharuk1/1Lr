using System;

namespace _1Lr
{
    class Program
    {
        static void Main()
        {
            double a, b, d1, d2,  Y, F;

            Console.WriteLine("Введите значение x: ");

            double x = Convert.ToDouble(Console.ReadLine());

            a = 0.5;
            b = 1.5;

            d1 = Math.Abs(x - a);
            d2 = Math.Log10(Math.Pow((Math.Abs(x) + 1), 2));

            Y = Math.Pow(x, 5) * (x * Math.Atan(a + x) - Math.Sqrt(d1) + d2);

            F = Math.Sqrt(a * x * x + b * x) * Math.Exp(-a * x) + Math.Log10(Math.Abs(x) + 1);
            
            Console.WriteLine("Y = "+ Y);
            Console.WriteLine("F = " + F);

        }
    }
}
