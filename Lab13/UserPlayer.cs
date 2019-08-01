using System;
namespace Lab13
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {

        }

        public UserPlayer(string name):base(name)
        {
            
            Name = name;
        }

        public static string ChooseRPS()
        {
            Console.WriteLine("\n\tSelect Rock, Paper, or Scissors");
            string userChoice = Console.ReadLine().ToLower();
            return userChoice;
        }
            

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
                return Roshambo.Scissors;
            }
        }
    }
}
