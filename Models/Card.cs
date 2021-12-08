using CasinoGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Models
{
    public class Card
    {
        public Card(CardType type, Suit suit, int value)
        {
            CardType = type;
            Suit = suit;
            Value = value;
        }

        public static CardType CardType { get; set; }
        public static Suit Suit { get; set; }
        public static int Value { get; set; }
    }
}
