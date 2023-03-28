class AnonymousFunction
{

    public static void Run()
    {

        List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

        var square = (int n) => { return n * n; };

        foreach (int num in nums)
        {
            Console.WriteLine(square(num));
        }

    }
}