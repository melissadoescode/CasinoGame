using CasinoGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Models
{
    public class Player
    {
        public static string Name { get; set; }
        public static List<CardService> Hand { get; set; }
        public static int Bet { get; set; }
        public static int Chips { get; set; } = 500;
        public static int HandsCompleted { get; set; } = 1;
        public static int Wins { get; set; }

        public Player(string name, int bankroll)
        {
            Name = name;
            Chips = bankroll;
        }
    }
}
