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
    }
}
