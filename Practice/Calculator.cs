public abstract class Calculator
{

    public abstract int Add(int[] Nums);
    public abstract int Subtract(int[] Nums);

    public static void Run()
    {

        Console.WriteLine("Enter the type of calculator you want to use (normal/opposite):");
        string calculatorType = Console.ReadLine()!.ToLower();

        Calculator Calc;

        if (calculatorType == "normal")
        {
            Calc = new NormalCalculator();
        }
        else if (calculatorType == "opposite")
        {
            Calc = new OppositeCalculator();
        }
        else
        {
            Console.WriteLine("Invalid calculator type.");
            return;
        }

        Console.WriteLine("Enter numbers: ");
        int[] Nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        Console.WriteLine("What action you would like to perform? (add/subtract): ");
        string action = Console.ReadLine()!.ToLower();

        int res;

        if (action == "add")
        {
            res = Calc.Add(Nums);
        }
        else if (action == "subtract")
        {
            res = Calc.Subtract(Nums);
        }
        else
        {
            Console.WriteLine("Invalid action.");
            return;
        }

        Console.WriteLine("The result of the calculation is: " + res);
    }
}

public class NormalCalculator : Calculator
{

    public override int Add(int[] Nums)
    {
        return Nums.Sum();
    }

    // subtract
    public override int Subtract(int[] Nums)
    {
        for (int i = 1; i < Nums.Length; i++)
        {
            Nums[i] *= -1;
        }
        return Add(Nums);
    }
}

public class OppositeCalculator : Calculator
{

    NormalCalculator Calc = new();

    public override int Add(int[] Nums)
    {
        return Calc.Subtract(Nums);
    }

    public override int Subtract(int[] Nums)
    {
        return Calc.Add(Nums);
    }
}