using System;
namespace Lab13
{
    public class UserPlayer : Player
    {
        public UserPlayer()
        {

        }

        public UserPlayer(string name):base(name)
        {
            
            Name = name;
        }


        //Get Rock Paper Selection
        public static string ChooseRPS()
        {
            Console.WriteLine("\n\tSelect Rock, Paper, or Scissors");
            string userChoice = Console.ReadLine().ToLower();
            return userChoice;
        }
            
        //Return Selection as Enum
        public override Roshambo GenerateRoshambo()
        {
            string userThrow = ChooseRPS();
            if (userThrow == "rock")
            {
                return Roshambo.Rock;
            }

            else if (userThrow == "paper")
            {
                return Roshambo.Paper;
            }

            else if (userThrow == "scissors")
            {
                return Roshambo.Scissors;
            }

            else 
            {
                Console.WriteLine("Invalid Input");
                ChooseRPS();
            }

            return Roshambo.Rock;
        }
    }
}
