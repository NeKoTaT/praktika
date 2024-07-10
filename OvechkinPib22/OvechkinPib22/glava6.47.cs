using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите первый член прогрессии f:");
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите шаг прогрессии s:");
        int s = int.Parse(Console.ReadLine());

        bool isMember = (n - f) % s == 0;
        Console.WriteLine($"Число {n} является членом арифметической прогрессии: {isMember}");
    }
}
