﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame.Interfaces
{
    public interface IDealerService
    {
        void RevealCard();
        int GetHandValue();
        void Display();
    }
}
