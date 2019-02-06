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

        bool draw = false;

        public Referee(Player[] pPlayers)
        {
            players = pPlayers;
        }

        public Player GetWinner()
        {
            Player winningPlayer = null;

            List<Player> winningPlayers = new List<Player>();

            for (int i = 0; i < players.Length; i++)
            {
                players[i].TakeTurn();

                if (winningPlayer != null)
                {
                    if (players[i].Score > winningPlayer.Score)
                    {
                        winningPlayer = players[i];
                    }
                }
                else
                {
                    winningPlayer = players[i];
                }
            }

            draw = false;

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] != winningPlayer)
                {
                    if(players[i].Score == winningPlayer.Score)
                    {
                        draw = true;

                        winningPlayers.Add(players[i]);
                    }
                }
            }

            if(draw)
            {
                Console.WriteLine("Rematch!");

                winningPlayers.Add(winningPlayer);

                winningPlayer = null;

                foreach (Player player in winningPlayers)
                {
                    player.TakeTurn();

                    if (winningPlayer != null)
                    {
                        if (player.Score > winningPlayer.Score)
                        {
                            winningPlayer = player;
                        }
                    }
                    else
                    {
                        winningPlayer = player;
                    }
                }
            }

            return winningPlayer;
        }
    }
}
