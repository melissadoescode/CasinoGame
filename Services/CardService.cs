using CasinoGame.Enums;
using CasinoGame.Interfaces;
using CasinoGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Services
{
    public class CardService : ICardService
    {
        private readonly SuitType suitType;
        private readonly CardType cardType;
        private readonly ConsoleColor color;
        private readonly char symbol;
        public int value;

        public CardService(SuitType suits, CardType cards)
        {
            this.suitType = suits;
            this.cardType = cards;

            switch (this.suitType)
            {
                case SuitType.Diamonds:
                    symbol = '♦';
                    color = ConsoleColor.Red;
                    break;
                case SuitType.Hearts:
                    symbol = '♥';
                    color = ConsoleColor.Red;
                    break;
                case SuitType.Spades:
                    symbol = '♠';
                    color = ConsoleColor.DarkGray;
                    break;
                case SuitType.Clubs:
                    symbol = '♣';
                    color = ConsoleColor.DarkGray;
                    break;
            }

            switch (this.cardType)
            {
                case CardType.Two:
                    value = 2;
                    break; 
                case CardType.Three:
                    value = 3;
                    break;
                case CardType.Four:
                    value = 4;
                    break;
                case CardType.Five:
                    value = 5;
                    break;
                case CardType.Six:
                    value = 6;
                    break;
                case CardType.Seven:
                    value = 7;
                    break;
                case CardType.Eight:
                    value = 8;
                    break;
                case CardType.Nine:
                    value = 9;
                    break;
                case CardType.Ten:
                case CardType.Jack:
                case CardType.Queen:
                case CardType.King:
                    value = 10;
                    break;
                case CardType.Ace:
                    value = 1;
                    break;
            }
        }

        public void Display()
        {
            Console.ForegroundColor = color;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(symbol + " " + cardType + " of " + suitType);
            Console.ResetColor();
        }

        //private List<Suit> _suits;
        //public List<Suit> Suits
        //{
        //    get
        //    {
        //        _suits = _suits ?? getSuits();
        //        return _suits;
        //    }
        //}

        //private List<Card> _cards;
        //public List<Card> Cards
        //{
        //    get
        //    {
        //        _cards = _cards ?? getCards(Suits);
        //        return _cards;
        //    }
        //}

        //private List<Suit> getSuits() =>
        //       new List<Suit>
        //       {
        //        new Suit(SuitType.Diamonds, '♦', ConsoleColor.Red),
        //        new Suit(SuitType.Hearts, '♥', ConsoleColor.Red),
        //        new Suit(SuitType.Spades, '♠', ConsoleColor.Black),
        //        new Suit(SuitType.Clubs, '♣', ConsoleColor.Black)
        //       };

        //private List<Card> getCards(List<Suit> suits)
        //{
        //    var cards = new List<Card>();

        //    suits.ForEach(s =>
        //    {
        //        cards.Add(new Card(CardType.Ace, s, "A", 1));
        //        cards.Add(new Card(CardType.Two, s, "2", 2));
        //        cards.Add(new Card(CardType.Three, s, "3", 3));
        //        cards.Add(new Card(CardType.Four, s, "4", 4));
        //        cards.Add(new Card(CardType.Five, s, "5", 5));
        //        cards.Add(new Card(CardType.Six, s, "6", 6));
        //        cards.Add(new Card(CardType.Seven, s, "7", 7));
        //        cards.Add(new Card(CardType.Eight, s, "8", 8));
        //        cards.Add(new Card(CardType.Nine, s, "9", 9));
        //        cards.Add(new Card(CardType.Ten, s, "10", 10));
        //        cards.Add(new Card(CardType.Jack, s, "J", 10));
        //        cards.Add(new Card(CardType.Queen, s, "Q", 10));
        //        cards.Add(new Card(CardType.King, s, "K", 10));
        //    });

        //    return cards;
        //}
    }
}
