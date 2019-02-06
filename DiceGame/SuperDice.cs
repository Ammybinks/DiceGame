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

        public SuperDice()
        {
            letters[0] = "A";
            letters[1] = "B";
            letters[2] = "C";
        }

        public override int Roll()
        {
            int regRoll = base.Roll();
            int supRoll = rng.Next(1, 11);
            int letRoll = CheckLetters();

            int sum = regRoll + supRoll + letRoll;
            Console.WriteLine($"I rolled {regRoll}, {supRoll} and {letRoll} with a result of {sum}");

            return sum;
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
