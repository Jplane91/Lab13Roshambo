using System;

namespace Lab13
{
    public enum Roshambo { Rock = 1, Paper = 2, Scissors = 3 }

    class Program
    {
        static void Main(string[] args)
        {
            UserPlayer user = new UserPlayer();
            Prompts.SayHello();
            Prompts.GetUserName(user);

            bool whichOppenent = RoshamboApp.AskForOppenent();
            if (whichOppenent == true)
            {

                MatchupVsOpponent1.DecideWinner(user);
            }
                
            
            else
            {
                MatchupVsOppenent2.DecideWinner(user);
            }
                 
        }
   
    }
}
