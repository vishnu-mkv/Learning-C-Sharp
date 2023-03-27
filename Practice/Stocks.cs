using System;

class Stocks
{

    public static void Run()
    {

        Console.WriteLine("Enter the stock prices");

        int Profit = 0;
        int[] Prices = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int Minimum = Prices[0];

        for (int i = 1; i < Prices.Length; i++)
        {
            Minimum = Math.Min(Minimum, Prices[i]);
            Profit = Math.Max(Profit, Prices[i] - Minimum);
        }

        Console.WriteLine("Max Profit Possible: " + Profit);
    }
}