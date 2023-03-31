class AsyncOrder
{
    public static async Task Run()
    {
        Task[] Tasks = new Task[] {
            DecorateStage(),
            DropRawMaterials(),
            ReviewSpeech(),
            PickUpGuest(),
            BringPrizes(),
        };
        await Task.WhenAll(Tasks);

        await CheckSecurity();
        await GiveSpeech();
        await DistributePrizes();
        await ServeFood();
    }

    static async Task PickUpGuest()
    {
        Console.WriteLine("Picking up the chief guest from the airport.");
        await Task.Delay(3000);
        Console.WriteLine("Chief guest picked up successfully.");
    }

    static async Task DecorateStage()
    {
        Console.WriteLine("Decorating the stage.");
        await Task.Delay(2000);
        Console.WriteLine("Stage decorated successfully.");
    }

    static async Task PrepareFood()
    {
        Console.WriteLine("Preparing food.");
        await Task.Delay(5000);
        Console.WriteLine("Food prepared successfully.");
    }

    static async Task DropRawMaterials()
    {
        Console.WriteLine("Dropping raw materials for cooking.");
        await Task.Delay(1000);
        Console.WriteLine("Raw materials dropped successfully.");
        await PrepareFood();
    }

    static async Task ReviewSpeech()
    {
        Console.WriteLine("Reviewing the chief guest's speech.");
        await Task.Delay(2000);
        Console.WriteLine("Speech reviewed successfully.");
    }

    static async Task CheckSecurity()
    {
        Console.WriteLine("Checking venue for security features.");
        await Task.Delay(2000);
        Console.WriteLine("Security check completed successfully.");
    }

    static async Task BringPrizes()
    {
        Console.WriteLine("Bringing prizes to the venue.");
        await Task.Delay(2000);
        Console.WriteLine("Prizes brought successfully.");
    }

    static async Task GiveSpeech()
    {
        Console.WriteLine("Chief guest is giving the speech.");
        await Task.Delay(6000);
        Console.WriteLine("Speech given successfully.");
    }

    static async Task DistributePrizes()
    {
        Console.WriteLine("Distributing prizes.");
        await Task.Delay(3000);
        Console.WriteLine("Prizes distributed successfully.");
    }

    static async Task ServeFood()
    {
        Console.WriteLine("Serving food to all participants.");
        await Task.Delay(4000);
        Console.WriteLine("Food served successfully.");
    }
}
