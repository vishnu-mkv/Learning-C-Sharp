using System;


namespace Basics
{
    internal class Arrays
    {
        public void SingleArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void MultiDimensionArray()
        {
            int[,] arr =
            {
                {1,2 },
                {1,2 }
            };
        }
        public void JaggedArray()
        {
            int[][,] arr = new int[3][,]{
                     new int[,] { {1,3}, {5,7} },
                     new int[,] { {0,2}, {4,6}, {8,10} },
                     new int[,] { {11,22}, {99,88}, {0,9} }
            };

        }
    }
}