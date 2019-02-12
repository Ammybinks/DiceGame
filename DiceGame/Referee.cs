using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Referee
    {
        Player[] players;
        int[] scores;

        bool draw = false;

        public Referee(Player[] pPlayers)
        {
            players = pPlayers;

            scores = new int[players.Length];
        }

        public Player GetWinner()
        {
            int winningScore = -1;

            List<int> winningScores = new List<int>();

            for (int i = 0; i < players.Length; i++)
            {
                scores[i] = players[i].TakeTurn();

                if (winningScore != -1)
                {
                    if (scores[i] > scores[winningScore])
                    {
                        winningScore = i;
                    }
                }
                else
                {
                    winningScore = i;
                }
            }

            draw = false;

            for (int i = 0; i < players.Length; i++)
            {
                if (i != winningScore)
                {
                    if(scores[i] == scores[winningScore])
                    {
                        draw = true;

                        winningScores.Add(i);
                    }
                }
            }

            if(draw)
            {
                Console.WriteLine("Rematch!");

                winningScores.Add(winningScore);

                winningScore = -1;

                foreach (int player in winningScores)
                {
                    scores[player] = players[player].TakeTurn();

                    if (winningScore != -1)
                    {
                        if (scores[player] > scores[winningScore])
                        {
                            winningScore = player;
                        }
                    }
                    else
                    {
                        winningScore = player;
                    }
                }
            }

            return players[winningScore];
        }
    }
}
