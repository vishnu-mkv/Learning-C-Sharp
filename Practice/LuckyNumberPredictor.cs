using System;

namespace LuckyNumberPredictor
{
    public abstract class NumberPredictor
    {
        public abstract int CalculateLuckyNumber(DateTime dateOfBirth);
        public abstract int CalculateUnluckyNumber(DateTime dateOfBirth);
    }

    public class FibonacciNumberPredictor : NumberPredictor
    {
        private int GetNearestFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            while (b < n)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            if (Math.Abs(n - a) <= Math.Abs(b - n))
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public override int CalculateLuckyNumber(DateTime dateOfBirth)
        {
            int roundedDateOfBirth = GetNearestFibonacci(dateOfBirth.Day);

            return roundedDateOfBirth;
        }

        public override int CalculateUnluckyNumber(DateTime dateOfBirth)
        {
            // For now, we don't have a formula for calculating the unlucky number, so we'll return a default value of -1.
            return -1;
        }
    }

    public class LuckyNumberPredictorApp
    {
        private NumberPredictor numberPredictor;

        public LuckyNumberPredictorApp(NumberPredictor numberPredictor)
        {
            this.numberPredictor = numberPredictor;
        }

        public int GetLuckyNumber(DateTime dateOfBirth)
        {
            int luckyNumber = numberPredictor.CalculateLuckyNumber(dateOfBirth);

            return luckyNumber;
        }

        public int GetUnluckyNumber(DateTime dateOfBirth)
        {
            int unluckyNumber = numberPredictor.CalculateUnluckyNumber(dateOfBirth);

            return unluckyNumber;
        }
    }

    class Prediction
    {
        public static void Run()
        {
            NumberPredictor numberPredictor = new FibonacciNumberPredictor();
            LuckyNumberPredictorApp app = new LuckyNumberPredictorApp(numberPredictor);

            Console.WriteLine("Enter your date of birth (DD/MM/YYYY):");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine()!);

            int luckyNumber = app.GetLuckyNumber(dateOfBirth);
            Console.WriteLine($"Your lucky number is: {luckyNumber}");

            // int unluckyNumber = app.GetUnluckyNumber(dateOfBirth);
            // Console.WriteLine($"Your unlucky number is: {unluckyNumber}");
        }
    }
}
