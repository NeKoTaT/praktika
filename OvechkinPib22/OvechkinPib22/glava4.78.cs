using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[6];
        Console.WriteLine("Введите 6 чисел:");

        for (int i = 0; i < 6; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int product = 1;
        for (int i = 0; i < 6; i++)
        {
            product *= numbers[i];
        }

        Console.WriteLine("Произведение чисел: " + product);
    }
}
