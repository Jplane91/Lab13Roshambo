using System;
namespace Lab13
{
    public class RoshamboApp
    {
        public static bool AskForOppenent()
        {
            Console.WriteLine("Which oppenent would you like to play, Levi or Jonathan?");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "levi")
            {
                return true;
            }

            else if (userAnswer == "jonathan")
            {
                return false;
            }

            else
            {
                Console.WriteLine("Invalid input");
                AskForOppenent();
            }

            return true;

        }

    }
}
