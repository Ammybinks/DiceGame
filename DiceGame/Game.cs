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

        Dice dice;

        public void StartGame()
        {
            dice = new SuperDice();

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
                players[i] = new Player(dice);
                Console.WriteLine($"Name player {i}");
                players[i].SetName(Console.ReadLine());
            }

            referee = new Referee(players);
            
            while(true)
            {
                winner = referee.GetWinner();

                Console.WriteLine($"The winner is {winner.Name} with a score of {winner.Score}");
                Console.ReadKey();
            }
        }
    }
}
