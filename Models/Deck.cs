using CasinoGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Models
{
    public class Deck
    {
        public static List<CardService> Cards { get; set; } = new List<CardService>();
    }
}
