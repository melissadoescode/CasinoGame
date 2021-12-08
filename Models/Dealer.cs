using CasinoGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Models
{
    public class Dealer
    {
        public static List<CardService> HiddenCards { get; set; } = new List<CardService>();
        public static List<CardService> RevealedCards { get; set; } = new List<CardService>();
    }
}
