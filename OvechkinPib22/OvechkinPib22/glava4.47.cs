using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три целых числа:");
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Четные числа:");
        for (int i = 0; i < 3; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
