using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Player
    {
        private string name;

        private int score;

        private Dice dice;

        public string Name
        {
            get { return name; }
        }

        public int Score
        {
            get { return score; }
        }

        public Player(Dice pDice)
        {
            dice = pDice;
        }

        public void SetName(string pName)
        {
            name = pName;
        }

        public void TakeTurn()
        {
            score = dice.Roll();
        }
    }
}
