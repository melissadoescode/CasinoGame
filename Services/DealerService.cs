using CasinoGame.Interfaces;
using CasinoGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Services
{
    public class DealerService : IDealerService
    {
        private readonly string name = "Dealer";

        public void RevealCard()
        {
            Dealer.RevealedCards.Add(Dealer.HiddenCards[0]);
            Dealer.HiddenCards.RemoveAt(0);
        }

        public int GetHandValue()
        {
            int value = 0;
            foreach (CardService card in Dealer.RevealedCards)
            {
                value += card.value;
            }
            return value;
        }

        public void Display()
        {
            Console.WriteLine($"Dealer's Hand ({GetHandValue()}): ");
            foreach (CardService card in Dealer.RevealedCards)
            {
                card.Display();
            }
            for (int i = 0; i < Dealer.HiddenCards.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("hidden card");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
        }
    }
}
