
using System;

class Program
{
    static double S(double a, double b)
    {
        double sum = a + b;
        double result = sum * sum;
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double square = S(num1, num2);

        Console.WriteLine($"Ответ: {square}");
    }
}

       