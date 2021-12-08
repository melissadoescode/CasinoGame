using CasinoGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Interfaces
{
    public interface ICasinoService
    {
        void Initialize();
        void StartRound();
        void GetActions();
        bool GetBetAmount();
        void EndRound(ResultType result);
    }
}
