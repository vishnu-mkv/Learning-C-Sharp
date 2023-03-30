using System;

namespace Basics
{
    internal class Sara
    {
        public static void GetUserAge()
        {
            Console.WriteLine("Please enter your birthday (mm/dd/yyyy): ");
            DateTime birthday;
            if (DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                TimeSpan age = DateTime.Now - birthday;
                int years = (int)(age.TotalDays / 365.25); // accounting for leap years
                Console.WriteLine($"You are {years} years old.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please try again.");
            }
        }

        static void PersonalityTrait()
        {
            Console.WriteLine("Welcome to the Personality Trait Application!");

            // Ask questions
            Console.WriteLine("How often do you socialize with others? (1-5)");
            int socialize = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you prefer staying at home or going out? (home/out)");
            string preference = Console.ReadLine();
            Console.WriteLine("What type of books do you like to read? (fiction/non-fiction)");
            string bookType = Console.ReadLine();
            Console.WriteLine("Are you an optimist or a pessimist? (optimist/pessimist)");
            string outlook = Console.ReadLine();

            // Determine personality trait
            string trait = "";
            if (socialize >= 4 && preference == "out" && bookType == "fiction" && outlook == "optimist")
            {
                trait = "outgoing and adventurous";
            }
            else if (socialize >= 3 && preference == "home" && bookType == "non-fiction" && outlook == "pessimist")
            {
                trait = "introspective and analytical";
            }
            else if (socialize >= 2 && preference == "out" && bookType == "fiction" && outlook == "pessimist")
            {
                trait = "cautious and imaginative";
            }
            else
            {
                trait = "difficult to determine";
            }

            // Display result
            Console.WriteLine($"Based on your answers, you seem to be {trait}.");
        }

        static void Zodiac()
        {
            Console.WriteLine("Welcome to the Personality Trait Application!");

            // Ask for birth month
            Console.WriteLine("Please enter your birth month (1-12):");
            int birthMonth = int.Parse(Console.ReadLine());

            // Determine zodiac sign
            string zodiacSign = "";
            switch (birthMonth)
            {
                case 1:
                    zodiacSign = "Capricorn";
                    break;
                case 2:
                    zodiacSign = "Aquarius";
                    break;
                case 3:
                    zodiacSign = "Pisces";
                    break;
                case 4:
                    zodiacSign = "Aries";
                    break;
                case 5:
                    zodiacSign = "Taurus";
                    break;
                case 6:
                    zodiacSign = "Gemini";
                    break;
                case 7:
                    zodiacSign = "Cancer";
                    break;
                case 8:
                    zodiacSign = "Leo";
                    break;
                case 9:
                    zodiacSign = "Virgo";
                    break;
                case 10:
                    zodiacSign = "Libra";
                    break;
                case 11:
                    zodiacSign = "Scorpio";
                    break;
                case 12:
                    zodiacSign = "Sagittarius";
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    return;
            }

            Console.WriteLine("Your zodiacSign is: " + zodiacSign);
        }

        public static void Run()
        {

            PersonalityTrait();
            Console.WriteLine();
            Zodiac();
            Console.WriteLine();
            GetUserAge();
        }

    }
}
