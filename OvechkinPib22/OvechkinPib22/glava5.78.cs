using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество отрезков разбиения (чем больше, тем точнее):");
        int n = int.Parse(Console.ReadLine());

        double h = Math.PI / n;
        double area = 0;

        for (int i = 0; i < n; i++)
        {
            double x1 = i * h;
            double x2 = (i + 1) * h;
            double y1 = Math.Sin(x1);
            double y2 = Math.Sin(x2);
            area += (y1 + y2) * h / 2;
        }

        Console.WriteLine("Приближенная площадь одной арки синусоиды: " + area);
    }
}
