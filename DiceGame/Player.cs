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
        private int[] scores;

        private Dice dice;

        public string Name
        {
            get { return name; }
        }
        
        public Player(Dice pDice)
        {
            dice = pDice;
        }

        public void SetName(string pName)
        {
            name = pName;
        }

        public int TakeTurn()
        {
            scores = dice.Roll();

            score = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                score += scores[i];
            }

            Console.WriteLine($"{name} rolled {scores[0]}, {scores[1]} and {scores[2]}. Scoring a total of {score}");

            return score;
        }
    }
}
