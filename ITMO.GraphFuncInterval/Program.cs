using System;

namespace ITMO.GraphFuncInterval
{
    class Program
    {
        static double GetNumber(string Str)
        {
            Console.Write(Str);
            string tmpStr = Console.ReadLine();
            double dd = double.Parse(tmpStr);
            return dd;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Алгоритм вычисление графика функций в заданном интервале");
            Console.WriteLine("Ввод параметров: ");

            double a, b, c, x1, x2, dx, z;
            a = GetNumber("a = ");
            b = GetNumber("b = ");
            c = GetNumber("c = ");

            Console.WriteLine("Ввод интервалов и дифференциала: ");

            x1 = GetNumber("x1 = ");
            x2 = GetNumber("x2 = ");
            dx = GetNumber("dx = ");

            double x = x1;
            double exp = 2.71;

            while (x <= x2)
            {
                z = a * exp * (b * x - c * x * x);
                Console.WriteLine($"Ответ:\nX = {x}, Z = {z}");
                x += dx;
            }
            Console.ReadKey();
        }
    }
}