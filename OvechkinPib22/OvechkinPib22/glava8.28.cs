using System;

class Program
{
    static void Main()
    {
        int[] weights = { 100, 200, 300, 500, 1000, 1200, 1400, 1500, 2000, 3000 };
        Console.WriteLine("Введите вес v в граммах:");
        int v = int.Parse(Console.ReadLine());

        int ways = CountWays(weights, v);
        Console.WriteLine($"Количество способов составить вес {v} грамм: {ways}");
    }

    static int CountWays(int[] weights, int v)
    {
        int[] dp = new int[v + 1];
        dp[0] = 1;

        for (int i = 0; i < weights.Length; i++)
        {
            for (int j = weights[i]; j <= v; j++)
            {
                dp[j] += dp[j - weights[i]];
            }
        }

        return dp[v];
    }
}
