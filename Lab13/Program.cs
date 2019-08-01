using System;

namespace Lab13
{
    enum Roshambo { Rock = 1, Paper = 2, Scissors = 3 }

    class Program
    {
        static void Main(string[] args)
        {

            Prompts.SayHello();
            Prompts.GetUserName();
            bool whichOppenent = RoshamboApp.AskForOppenent();
            if (whichOppenent == true)
            {

                MatchupVsOppenent1.DecideWinner();
            }
                
            
            else
            {
                MatchupVsOpponent2.DecideWinner();
            }
                 
        }
               

    }
}
