using System.Collections.Generic;
using System;

namespace BlazorApp.Pages
{
    public partial class Dobbelen
    {
        private List<Player> players = new List<Player>();
        private string resultMessage = "";
        private int antwoord;

        private void Reset()
        {
            players = new List<Player>();
            resultMessage = "";
            antwoord = 0;
        }

        private void Play()
        {
            Reset();

            int count = 0;

            for (int i = 1; i <= 12; i++)
            {
                int dice = new Random().Next(1, 7);

                players.Add(new Player
                {
                    Number = i,
                    IsSix = dice == 6
                });

                if (players[i - 1].IsSix)
                {
                    count++;
                }
            }

            resultMessage = $"{count} speler(s) gooide een 6.";

            if (antwoord == count)
            {
                resultMessage += " Gewonnen. Juist geraden!";
            }
            else
            {
                resultMessage += $" Oeps. {count} speler(s) gooiden een zes. Probeer nog eens...";
            }
        }

        private class Player
        {
            public int Number { get; set; }
            public bool IsSix { get; set; }
        }
    }
}
