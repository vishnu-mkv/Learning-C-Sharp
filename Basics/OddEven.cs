using System;

class OddEven
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] oddArr = new int[arr.Length];
        int[] evenArr = new int[arr.Length];
        int oddCount = 0, evenCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenArr[evenCount++] = arr[i];
            }
            else
            {
                oddArr[oddCount++] = arr[i];
            }
        }

        Console.WriteLine("Odd integers: ");
        for (int i = 0; i < oddCount; i++)
        {
            Console.Write(oddArr[i] + " ");
        }

        Console.WriteLine("\nEven integers: ");
        for (int i = 0; i < evenCount; i++)
        {
            Console.Write(evenArr[i] + " ");
        }
    }
}
