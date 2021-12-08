using CasinoGame.Interfaces;
using CasinoGame.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Services
{
    public class PlayerService : IPlayerService
    {
        public void ClearBet()
        {
            Player.Bet = 0;
        }

        public void AddBet(int bet)
        {
            Player.Bet += bet;
            Player.Chips -= bet;
        }

        public void ReturnBet()
        {
            Player.Chips += Player.Bet;
            ClearBet();
        }

        public int Win()
        {
            int chipsWon;
            chipsWon = Player.Bet * 2;
            Player.Chips += chipsWon;
            ClearBet();
            return chipsWon;
        }

        public int GetHandValue()
        {
            int value = 0;
            foreach (CardService card in Player.Hand)
            {
                value += card.value;
            }
            return value;
        }

        public void Display()
        {
            Console.WriteLine($"\n{new string('-', 60)}\n" +
                              $"{Player.Name}'s Stats" +
                              $"\n{new string('-', 60)}" +
                              $"\nBet: {Player.Bet}" +
                              $"\nChips: {Player.Chips}" +
                              $"\nTotal games won: {Player.Wins}" +
                              $"\nRound Number: {Player.HandsCompleted}" +
                              $"\n{new string('-', 60)}\n");
            Console.WriteLine($"Your Hand ({GetHandValue()}): ");
            foreach (CardService card in Player.Hand)
            {
                card.Display();
            }
            Console.WriteLine();
        }
    }
}
