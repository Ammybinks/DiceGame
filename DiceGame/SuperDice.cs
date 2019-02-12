using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class SuperDice: Dice
    {
        int[] rolls = new int[3];

        string[] letters = new string[3];

        public SuperDice()
        {
            letters[0] = "A";
            letters[1] = "B";
            letters[2] = "C";
        }
        
        public override int[] Roll()
        {
            rolls[0] = base.Roll()[0];
            rolls[1] = rng.Next(1, 11);
            rolls[2] = CheckLetters();
            
            return rolls;
        }

        public int CheckLetters()
        {
            switch(letters[rng.Next(0, 3)])
            {
                case "A":
                    return 5;
                    break;
                case "B":
                    return 3;
                    break;
                case "C":
                    return 1;
                    break;
            }

            return 0;
        }
    }
}
