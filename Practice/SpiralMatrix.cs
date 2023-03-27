using System;

class SpiralMatrix
{
    public static void Run()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        int value = 1;
        int left = 0, right = columns - 1, top = 0, bottom = rows - 1;

        while (value <= rows * columns)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = value;
                value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = value;
                value++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = value;
                value++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = value;
                value++;
            }
            left++;
        }

        Console.WriteLine("Spiral matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
