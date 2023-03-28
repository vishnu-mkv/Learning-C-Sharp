class RotateImage
{

    public static void Run()
    {

        int N = Convert.ToInt32(Console.ReadLine());
        int M = Convert.ToInt32(Console.ReadLine());

        int[,] mat = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // transpose mat
        for (int i = 0; i < N / 2; i++)
        {
            for (int j = 0; j < M / 2; j++)
            {
                (mat[j, i], mat[i, j]) = (mat[i, j], mat[j, i]);
            }
        }

        // reverse rows
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M / 2; j++)
            {
                (mat[i, j], mat[i, M - j - 1]) = (mat[i, M - j - 1], mat[i, j]);
            }
        }

        // print mat
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}


