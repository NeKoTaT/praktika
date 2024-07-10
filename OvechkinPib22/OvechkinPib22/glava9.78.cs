using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое предложение:");
        string sentence1 = Console.ReadLine();
        Console.WriteLine("Введите второе предложение:");
        string sentence2 = Console.ReadLine();

        int count1 = CountLetterN(sentence1);
        int count2 = CountLetterN(sentence2);

        int total = count1 + count2;
        Console.WriteLine($"Общее количество букв 'н': {total}");
    }

    static int CountLetterN(string sentence)
    {
        int count = 0;
        foreach (char c in sentence)
        {
            if (c == 'н' || c == 'Н')
            {
                count++;
            }
        }
        return count;
    }
}
