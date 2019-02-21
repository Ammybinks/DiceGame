using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class SuperDice: Dice
    {
        string[] letters = new string[3];

        public SuperDice(Random pRng)
            :base(pRng)
        {
            letters[0] = "A";
            letters[1] = "B";
            letters[2] = "C";
        }
        
        public override int[] Roll()
        {
            int[] rolls = new int[3];

            rolls[0] = base.Roll()[0];
            rolls[1] = rng.Next(1, 11);
            rolls[2] = CheckLetters();

            Console.WriteLine($"{rolls[0]}, {rolls[1]} and {rolls[2]}");

            return rolls;
        }

        public int CheckLetters()
        {
            switch(letters[rng.Next(0, 3)])
            {
                case "A":
                    return 5;
                case "B":
                    return 3;
                case "C":
                    return 1;
            }

            return 0;
        }
    }
}
