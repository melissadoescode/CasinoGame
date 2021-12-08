using CasinoGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Interfaces
{
    public interface IDeckService
    {
        void Initialize();
        void Shuffle();
        List<CardService> GetCards();
        List<CardService> DealHand();
        CardService DrawCard();
    }
}
