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
    public class CasinoService : ICasinoService
    {
        private readonly DeckService deckService;
        private readonly PlayerService playerService;
        private readonly DealerService dealerService;

        private readonly int minBet = 10;
        private readonly int maxBet = 500;

        public CasinoService()
        {
            deckService = new DeckService();
            playerService = new PlayerService();
            dealerService = new DealerService();
        }

        public void Initialize()
        {
            deckService.Initialize();

            Player.Hand = deckService.DealHand();
            Dealer.HiddenCards = deckService.DealHand();
            Dealer.RevealedCards = new List<CardService>();

            dealerService.RevealCard();

            playerService.Display();
            dealerService.Display();
        }

        public void StartRound()
        {
            Console.Clear();

            if (!GetBetAmount())
            {
                EndRound(ResultType.Invalid);
                return;
            }
            Console.Clear();

            Initialize();
            GetActions();

            dealerService.RevealCard();

            Console.Clear();
            playerService.Display();
            dealerService.Display();

            Player.HandsCompleted++;

            if (playerService.GetHandValue() > 21)
            {
                EndRound(ResultType.PlayerLoses);
                return;
            }

            while (dealerService.GetHandValue() <= 16)
            {
                Thread.Sleep(1000);
                Dealer.RevealedCards.Add(deckService.DrawCard());

                Console.Clear();
                playerService.Display();
                dealerService.Display();
            }


            if (playerService.GetHandValue() > dealerService.GetHandValue())
            {
                Player.Wins++;
                EndRound(ResultType.PlayerWins);
                
            }
            else if (dealerService.GetHandValue() > 21)
            {
                Player.Wins++;
                EndRound(ResultType.PlayerWins);
            }
            else if (dealerService.GetHandValue() > playerService.GetHandValue())
            {
                EndRound(ResultType.DealerWins);
            }
            else
            {
                EndRound(ResultType.Draw);
            }
        }

        public void GetActions()
        {
            string action;
            do
            {
                Console.Clear();
                playerService.Display();
                dealerService.Display();

                Console.Write("What's your play? (Type ? for help): ");
                action = Console.ReadLine();

                switch (action.ToUpper())
                {
                    case "HIT":
                        Player.Hand.Add(deckService.DrawCard());
                        break;
                    case "STAND":
                        break;
                    default:
                        Console.WriteLine($"\n{new string('-', 60)}\n" +
                                          $"Valid Moves:" +
                                          $"\n{new string('-', 60)}" +
                                          $"\nType 'Hit' or 'Stand'" +
                                          $"\nHit: The option to take another card if you don’t believe " +
                                          $"\nyour hand will beat the dealer's as it stands. Remember " +
                                          $"\nthat you’ll lose if your new card takes your hand value " +
                                          $"\nover 21." +
                                          $"\nStand: To stand is to choose not to take any additional " +
                                          $"\ncards. This is done when you think you’ll beat the dealer," +
                                          $"\nor when taking another card would make the risk of a loss " +
                                          $"\ntoo high." +
                                          $"\n{new string('-', 60)}\n " +
                                          $"Rules: " +
                                          $"\n{new string('-', 60)}" +
                                          $"\n- The player is dealt cards until they choose to stop recieving new cards (hit or stand). " +
                                          $"\n- The players total is added each time they get a new card." +
                                          $"\n- The player loses if their hand value goes over the count of 21." +
                                          $"\n- If the player chooses to stand before 21, the dealer will have a turn of recieving cards." +
                                          $"\n- The dealer loses if their hand value goes over the count of 21." +
                                          $"\n- The highest hand wins" +
                                          $"\n\n Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            } while (!action.ToUpper().Equals("STAND") && playerService.GetHandValue() <= 21);
        }

        public bool GetBetAmount()
        {
            Console.Write($"Current Chip Count: {Player.Chips}" +
                          $"\nNote: Minimum Bet - R{minBet} & Maximum Bet - R{maxBet}\n");
            Console.Write($"\nHow much are you betting for round {Player.HandsCompleted}? R");
            string s = Console.ReadLine();

            if (Int32.TryParse(s, out int bet) && bet >= 10 && Player.Chips >= bet)
            {
                playerService.AddBet(bet);
                return true;
            }
            return false;
        }

        public void EndRound(ResultType result)
        {
            switch (result)
            {
                case ResultType.PlayerWins:
                    Console.WriteLine($"{Player.Name} Wins " + playerService.Win() + " chips");
                    break;
                case ResultType.PlayerLoses:
                    playerService.ClearBet();
                    Console.WriteLine($"{Player.Name} Loses");
                    break;
                case ResultType.Draw:
                    playerService.ReturnBet();
                    Console.WriteLine($"{Player.Name} and Dealer drew.");
                    break;
                case ResultType.DealerWins:
                    playerService.ClearBet();
                    Console.WriteLine("Dealer Wins.");
                    break;
                case ResultType.Invalid:
                    Console.WriteLine("Invalid Bet.");
                    break;
            }

            if (Player.Chips <= 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Oh No {Player.Name}, you ran out of Chips after {Player.HandsCompleted} rounds");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            StartRound();
        }
    }
}
