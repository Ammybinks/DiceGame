using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Game
    {
        Player winner;

        Player[] players;

        Referee referee;

        Random rng = new Random();

        iDice[] dice;

        public void StartGame()
        {
            //Initialise dice list
            dice = new iDice[2];

            dice[0] = new Dice(rng);
            dice[1] = new SuperDice(rng);

            Console.WriteLine("How many players?");
            while (true)
            {
                try
                {
                    players = new Player[Convert.ToInt32(Console.ReadLine())];
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a number!");
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player(dice[rng.Next(0, dice.Length)]);
                Console.WriteLine($"Name player {i}");
                players[i].SetName(Console.ReadLine());
            }

            referee = new Referee();
            
            while(true)
            {
                for(int i = 0; i < players.Length; i++)
                {
                    players[i].TakeTurn();
                }

                referee.GetWinner(players);

                Console.ReadKey();
            }
        }
    }
}
