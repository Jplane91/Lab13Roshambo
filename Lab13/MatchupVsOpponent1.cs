using System;
namespace Lab13
{
    public class MatchupVsOpponent1
    {
        public static void DecideWinner(UserPlayer user)
        {
            int userWinTally = 0;
            int computerWinTally = 0;

            bool loop = true;
            while (loop)
            {   
                //Rock - 1, Paper - 2, Scissors - 3

                Opponent1 opponent1 = new Opponent1("");//Opponent 1 Instance

                int result = (int)user.GenerateRoshambo(); //Returns User's Enum, and casts into an interger
                int result2 = (int)opponent1.GenerateRoshambo(); //Returns Opponent's 1 Enum (Rock), and casts into an interger

                #region RPS Outcomes

                if (result == 1 && result2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\tPaper covers rock");
                    Console.WriteLine("\t" + opponent1.Name + " beats " + user.Name);
                    computerWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);

                }

                else if (result == 1 && result2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\tRock beats scissors");
                    Console.WriteLine("\t" + user.Name + " beats " + opponent1.Name);
                    userWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);


                }
                else if (result == 1 && result2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\tDraw");
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);

                }

                else if (result == 2 && result2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\tPaper covers rock");
                    Console.WriteLine("\t" + user.Name + " beats " + opponent1.Name);
                    userWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);

                }

                else if (result == 2 && result2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\tDraw");
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);


                }

                else if (result == 2 && result2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\tScissors cuts paper");
                    Console.WriteLine("\t" + opponent1.Name + " beats " + user.Name);
                    computerWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);

                }

                else if (result == 3 && result2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\tRock beats scissors");
                    Console.WriteLine("\t" + opponent1.Name + " beats " + user.Name);
                    computerWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);

                }

                else if (result == 3 && result2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\tScissors cuts paper");
                    Console.WriteLine("\t" + user.Name + " beats " + opponent1.Name);
                    userWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent1.Name);


                }

                else if (result == 3 && result2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\tDraw");

                }
                #endregion 

                bool playAgain = Prompts.AskToPlayAgain();
                if (playAgain == true)
                {
                    loop = true;
                }

                else
                {
                    Console.WriteLine("Have a good day!");
                    System.Environment.Exit(1);
                }

            }
        }
    }
}
