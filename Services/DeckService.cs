using CasinoGame.Enums;
using CasinoGame.Interfaces;
using CasinoGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CasinoGame.Services
{
    public class DeckService : IDeckService
    {
        public DeckService()
        {
            Initialize();
        }

        public void Initialize()
        {
            Console.WriteLine("Shuffling...");
            Thread.Sleep(3000);
            Deck.Cards = GetCards();
            Shuffle();
        }

        public void Shuffle()
        {
            Random rng = new Random();

            int j = Deck.Cards.Count;
            while (j > 1)
            {
                j--;
                int i = rng.Next(j + 1);
                CardService card = Deck.Cards[i];
                Deck.Cards[i] = Deck.Cards[j];
                Deck.Cards[j] = card;
            }
        }

        public List<CardService> GetCards()
        {
            List<CardService> getCards = new List<CardService>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    getCards.Add(new CardService((SuitType)j, (CardType)i));
                }
            }

            return getCards;
        }

        public List<CardService> DealHand()
        {
            List<CardService> hand = new List<CardService>();
            hand.Add(Deck.Cards[0]);
            hand.Add(Deck.Cards[1]);

            Deck.Cards.RemoveRange(0, 2);

            return hand;
        }

        public CardService DrawCard()
        {
            CardService card = Deck.Cards[0];
            Deck.Cards.Remove(card);

            return card;
        }
    }
}
