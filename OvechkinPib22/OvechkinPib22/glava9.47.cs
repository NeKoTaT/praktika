using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();

        bool isPalindrome = true;
        int length = word.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Слово является перевертышем.");
        }
        else
        {
            Console.WriteLine("Слово не является перевертышем.");
        }
    }
}
