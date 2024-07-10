using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символ:");
        char symbol = Console.ReadLine()[0];
        Console.WriteLine("Введите количество повторений:");
        int count = int.Parse(Console.ReadLine());

        string result = new string(symbol, count);
        Console.WriteLine("Сформированная строка: " + result);
    }
}
