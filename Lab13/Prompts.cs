using System;
namespace Lab13
{
    public class Prompts
    {
        public static void SayHello()
        {
            Console.WriteLine("Welcome to the Rock Paper Scissors Simulator");
   
        }

        public static void GetUserName()
        {
            UserPlayer user = new UserPlayer("");
            Console.WriteLine("What is your name?\n");
            user.Name = Console.ReadLine();
        }

        //public static bool AskForOppenent()
        //{
        //    Console.WriteLine("Which oppenent would you like to play, Levi or Jonathan?");
        //    string userAnswer = Console.ReadLine().ToLower();
        //    if (userAnswer == "levi")
        //    {
        //        return true;
        //    }

        //    else if (userAnswer == "jonathan")
        //    {
        //        return false;
        //    }

        //    else
        //    {
        //        Console.WriteLine("Invalid input");
        //        AskForOppenent();
        //    }

        //    return true;

        //}

        public static bool AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again? (yes or no)");
            string playAgainResponse = Console.ReadLine();
            if (playAgainResponse == "yes")
            {
                return true;
            }

            else if (playAgainResponse == "no")
            {
                return false;
            }

            else
            {
                Console.WriteLine("Invalid Respnse");
                AskToPlayAgain();
            }
            return true;
        }

    }
}
