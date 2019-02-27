using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Referee
    {
        int[] scores;

        bool draw = false;

        public Referee()
        {
        }

        public void GetWinner(Player[] players)
        {
            int index = -1;
            int listIndex = 0;

            List<List<Player>> places = new List<List<Player>>();
            places.Add(new List<Player>());
            places.Add(new List<Player>());
            places.Add(new List<Player>());

            players = SortWinners(players);

            for(int i = 0; i < players.Length; i++)
            {
                if(i + 1 < players.Length)
                {
                    if (players[i].Score != players[i + 1].Score && listIndex < places.Count)
                    {
                        for (int o = i; o > index; o--)
                        {
                            places.ElementAt(listIndex).Add(players[o]);
                        }

                        listIndex++;
                        index = i;
                    }
                }
            }

            listIndex = 0;

            foreach(List<Player> list in places)
            {
                Console.WriteLine(listIndex);

                foreach(Player player in list)
                {
                    Console.WriteLine($"{player.Name}, with a score of {player.Score}");
                }

                Console.WriteLine();

                listIndex++;
            }

            /*scores = new int[players.Length];

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

            return players[winningScore];*/
        }

        public Player[] SortWinners(Player[] players)
        {
            Player tempPlayer;

            for (int i = 0; i < players.Length; i++)
            {
                for (int j = 0; j < players.Length; j++)
                {
                    if(players[i].Score > players[j].Score)
                    {
                        tempPlayer = players[i];
                        players[i] = players[j];
                        players[j] = tempPlayer;
                    }
                }
            }

            return players;
        }
    }
}
