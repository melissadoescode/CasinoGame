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
    public class InteractionService : IInteractionService
    {
        public Player WelcomePlayer()
        {
            Console.Write("Welcome to the casino, what's your name? ");
            var name = Console.ReadLine();
            Console.Write($"Hello {name}, what is your bankroll today? ");
            var bankroll = int.Parse(Console.ReadLine());
            return new Player(name, bankroll);
        }
    }
}
