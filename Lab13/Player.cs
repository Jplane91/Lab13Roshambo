using System;
namespace Lab13
{
    abstract class Player
    {
        public string Name { get; set; }
        public abstract Roshambo GenerateRoshambo();

        public Player()
        {

        }

        public Player(string name)
        {

        }

        

    }
}
