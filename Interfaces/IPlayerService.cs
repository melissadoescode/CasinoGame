using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Interfaces
{
    public interface IPlayerService
    {
        void ClearBet();
        void AddBet(int bet);
        void ReturnBet();
        int Win();
        int GetHandValue();
        void Display();
    }
}
