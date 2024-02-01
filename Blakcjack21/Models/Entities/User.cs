using System;
using System.Collections.Generic;
using System.Linq;
 namespace Blakcjack21.Models.Entities
{
    internal interface User
    {
        public void Bet(int amount);
        public void AddCard(int count);
        public void Hit();
        public void Double();
        public void Pass();
        public void ShowHand();
    }
}
