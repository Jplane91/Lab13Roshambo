using System;
namespace Lab13
{
    public class MatchupVsOpponent2
    {
        public static void DecideWinner()
        {
            int userWinTally = 0;
            int computerWinTally = 0;

            bool loop = true;
            while (loop)
            {
                //Rock - 1, Paper - 2, Scissors - 3

                UserPlayer userPlayer = new UserPlayer("");
                Opponent2 opponent2 = new Opponent2("");

                int result = (int)userPlayer.GenerateRoshambo();
                int result2 = (int)opponent2.GenerateRoshambo();

                if (result == 1 && result2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\tPaper covers rock");
                    Console.WriteLine("\t" + opponent2.Name + " beats " + userPlayer.Name);
                    computerWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);

                }

                else if (result == 1 && result2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\tRock beats scissors");
                    Console.WriteLine("\t" + userPlayer.Name + " beats " + opponent2.Name);
                    userWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);


                }
                else if (result == 1 && result2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\tDraw");
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);

                }

                else if (result == 2 && result2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\tPaper covers rock");
                    Console.WriteLine("\t" + userPlayer.Name + " beats " + opponent2.Name);
                    userWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);

                }

                else if (result == 2 && result2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\tDraw");
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);


                }

                else if (result == 2 && result2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\tScissors cuts paper");
                    Console.WriteLine("\t" + opponent2.Name + " beats " + userPlayer.Name);
                    computerWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);

                }

                else if (result == 3 && result2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\tRock beats scissors");
                    Console.WriteLine("\t" + opponent2.Name + " beats " + userPlayer.Name);
                    computerWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);

                }

                else if (result == 3 && result2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\tScissors cuts paper");
                    Console.WriteLine("\t" + userPlayer.Name + " beats " + opponent2.Name);
                    userWinTally++;
                    Console.WriteLine("\tYou are " + userWinTally + " and " + computerWinTally + " against " + opponent2.Name);


                }

                else if (result == 3 && result2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\tDraw");

                }

                bool playAgain = Prompts.AskToPlayAgain();
                if (playAgain == true)
                {
                    loop = true;
                }

                else
                {
                    Console.WriteLine("Coward");
                    System.Environment.Exit(1);
                }

            }

        }

    }

}
