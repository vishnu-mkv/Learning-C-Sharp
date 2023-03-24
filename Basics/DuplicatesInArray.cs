using System;

class DuplicatesInArray
{
    static void aMain(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 3, 4, 5, 5, 6 };
        int duplicateCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    duplicateCount++;
                    break;
                }
            }
        }

        Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
    }
}
