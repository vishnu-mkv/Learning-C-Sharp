public class Delegates
{

    delegate void SumDelegate(int a, int b);

    public static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public static void Run()
    {
        SumDelegate s = Sum;
        s(1, 2);
        s.Invoke(3, 8);
    }
}

