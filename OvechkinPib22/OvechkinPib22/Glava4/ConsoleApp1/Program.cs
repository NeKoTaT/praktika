using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стороны треугольника a, b и c:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
        {
            Console.WriteLine("Треугольник является равнобедренным.");
        }
        else
        {
            Console.WriteLine("Треугольник не является равнобедренным.");
        }
    }
}
