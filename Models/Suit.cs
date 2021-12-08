using CasinoGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Models
{
    public class Suit
    {
        public Suit(SuitType suitType, char symbol, ConsoleColor color)
        {
            SuitType = suitType;
            Symbol = symbol;
            Color = color;
        }

        public SuitType SuitType { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }
        public string Abbreviation => SuitType.ToString().Substring(0, 1);
      }
}
