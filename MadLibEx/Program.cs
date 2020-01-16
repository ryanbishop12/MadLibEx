using System;

namespace MadLibEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = WelcomeMessage();
            string pluralNoun = PluralNoun();
            string illness = Illness();
            string adjOne = AdjectiveOne();
            string sillyOne = SillyWordOne();
            string adjTwo = AdjectiveTwo();
            string sillyTwo = SillyWordTwo();
            string place = Place();
            string number = Number();
            string adjThree = AdjectiveThree();

            Console.WriteLine("");
            Console.WriteLine("Dear School Nurse:");
            Console.WriteLine($"{sillyOne} {name} will not be attending school today.");
            Console.WriteLine($"He / she has come down with a case of {illness}");
            Console.WriteLine($"and has horrible {pluralNoun} and a/an {adjOne} fever.");
            Console.WriteLine($"We have made an appointment with the {adjTwo} Dr. {sillyTwo},");
            Console.WriteLine($"who studied for many years in {place} and has {number} degrees in pediatrics.");
            Console.WriteLine("He will send you all the information you need. Thank you!");
            Console.WriteLine("Sincerely");
            Console.WriteLine($"Mrs. {adjThree}.");
            Console.ReadLine();

        }
        private static string WelcomeMessage()
        {
            Console.WriteLine("Hello, Welcome to MadLibs");
            Console.Write("Please type your name : ");
            return Console.ReadLine();
        }
        private static string PluralNoun()
        {
            Console.Write("Please type a plural noun : ");
            return Console.ReadLine();
        }
        private static string Illness()
        {
            Console.Write("Please type an illness : ");
            return Console.ReadLine();
        }
        private static string AdjectiveOne()
        {
            Console.Write("Please type an adjective : ");
            return Console.ReadLine();
        }
        private static string SillyWordOne()
        {
            Console.Write("Please type a silly word : ");
            return Console.ReadLine();
        }
        private static string AdjectiveTwo()
        {
            Console.Write("Please type an adjective : ");
            return Console.ReadLine();
        }
        private static string SillyWordTwo()
        {
            Console.Write("Please type a silly word : ");
            return Console.ReadLine();
        }
        private static string Place()
        {
            Console.Write("Please type a place : ");
            return Console.ReadLine();
        }
        private static string Number()
        {
            Console.Write("Please type a number : ");
            return Console.ReadLine();
        }
        private static string AdjectiveThree()
        {
            Console.Write("Please type an adjective : ");
            return Console.ReadLine();
        }
    }
}
