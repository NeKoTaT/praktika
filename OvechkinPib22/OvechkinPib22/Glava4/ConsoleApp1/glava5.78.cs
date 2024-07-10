using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для проверки суммы цифр (a):");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для проверки произведения цифр (b):");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для проверки количества цифр (k):");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для проверки первой цифры (m):");
        int m = int.Parse(Console.ReadLine());

        // Инициализация переменных
        int sum = 0, product = 1, digits = 0;
        int temp = number;
        int firstDigit = number;

        // Подсчет суммы и произведения цифр, количества цифр
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            digits++;
            temp /= 10;
        }

        // Определение первой цифры
        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }

        // Проверка условий
        bool isSumLessThanA = sum < a;
        bool isProductGreaterThanB = product > b;
        bool isKDigitNumber = digits == k;
        bool isFirstDigitGreaterThanM = firstDigit > m;

        // Вывод результатов
        Console.WriteLine($"Сумма цифр числа меньше {a}: {isSumLessThanA}");
        Console.WriteLine($"Произведение цифр числа больше {b}: {isProductGreaterThanB}");
        Console.WriteLine($"Число {k}-значное: {isKDigitNumber}");
        Console.WriteLine($"Первая цифра числа больше {m}: {isFirstDigitGreaterThanM}");
    }
}
