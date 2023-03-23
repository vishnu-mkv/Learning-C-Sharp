namespace ConsoleApp1
{
    internal class HeroVillain
    {
        static void Main(string[] args)
        {

            int heroBullets = 10, villainBullets = 10, heroCurrent = 1, villainCurrent = 1;

            while (heroCurrent <= heroBullets && villainCurrent <= villainBullets)
            {
                Console.WriteLine("Hero - " + heroCurrent);
                heroCurrent++;


                Console.Write("Villain - ");
                for(int i=0; i<3 &&  villainCurrent <= villainBullets; villainCurrent++, i++)
                {
                    Console.Write(villainCurrent + " ");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine($"Hero fired : {heroCurrent-1} Bullets");
            Console.WriteLine($"Villain fired : {villainCurrent- 1} Bullets");

        }
    }
}       