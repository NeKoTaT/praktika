using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 200 до 500 с ровно шестью делителями:");

        for (int i = 200; i <= 500; i++)
        {
            int divisorCount = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    divisorCount++;
                }
            }

            if (divisorCount == 6)
            {
                Console.WriteLine(i);
            }
        }
    }
}
