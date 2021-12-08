using CasinoGame.Services;
using System;

namespace CasinoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var casino = new CasinoService();
            var interaction = new InteractionService();

            Console.Title = "Casino Game";
            interaction.WelcomePlayer();
            casino.StartRound();
        }
    }
}
