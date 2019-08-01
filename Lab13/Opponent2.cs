using System;
namespace Lab13
{
    class Opponent2 : Player
    {


        public Opponent2(string name) : base(name)
        {
            Name = name;
            Name = "Jonathan";

        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int randomRoshambo = random.Next(1, 4);
            if (randomRoshambo == 1)
            {
                return Roshambo.Rock;
            }

            else if (randomRoshambo == 2)
            {
                return Roshambo.Paper;
            }

            else
            {
                return Roshambo.Scissors;
            }
        }

    }
}
