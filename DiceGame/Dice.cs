using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Dice
    {
        internal Random rng;

        public Dice(Random pRng)
        {
            rng = pRng;
        }

        public virtual int[] Roll()
        {
            int[] rolls = new int[1];

            rolls[0] = rng.Next(1, 7);

            Console.WriteLine(rolls[0]);

            return rolls;
        }
    }
}
