using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Dice
    {
        internal Random rng = new Random();

        public virtual int Roll()
        {
            return rng.Next(1, 7);
        }
    }
}
