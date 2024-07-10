using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер k для вычисления k-го члена последовательности Фибоначчи:");
        int k = int.Parse(Console.ReadLine());

        int result = Fibonacci(k);
        Console.WriteLine($"k-й член последовательности Фибоначчи: {result}");
    }

    static int Fibonacci(int k)
    {
        if (k == 1 || k == 2)
        {
            return 1;
        }
        return Fibonacci(k - 1) + Fibonacci(k - 2);
    }
}
