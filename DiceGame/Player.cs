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
            Console.WriteLine($"{name} rolled ");
            scores = dice.Roll();

            score = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                score += scores[i];
            }

            Console.WriteLine($"Scoring a total of {score}");

            return score;
        }
    }
}
