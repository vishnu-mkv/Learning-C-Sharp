using System;

class MergeArrays
{
    static void aMain(string[] args)
    {
        int[] arr1 = new int[] { 1, 3, 5, 7, 9 };
        int[] arr2 = new int[] { 2, 4, 6, 8, 10 };
        int[] mergedArr = new int[arr1.Length + arr2.Length];

        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                mergedArr[k++] = arr1[i++];
            }
            else
            {
                mergedArr[k++] = arr2[j++];
            }
        }

        while (i < arr1.Length)
        {
            mergedArr[k++] = arr1[i++];
        }

        while (j < arr2.Length)
        {
            mergedArr[k++] = arr2[j++];
        }

        Console.WriteLine("Merged array: ");
        foreach (int num in mergedArr)
        {
            Console.Write(num + " ");
        }
    }
}
