using System;
namespace Lab13
{
    class Opponent1 : Player
    {


        public Opponent1(string name) : base(name)
        {
            Name = name;
            Name = "Levi";

        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}

