using Blakcjack21.Models.Stable;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Blakcjack21.Models.Entities
{
    internal class Game
    {
        // User properties
        public int UserBid { get; private set; }
        public int UserBalance { get; private set; }

        public Game(int userBalance)
        {
            this.UserBalance = userBalance;
            this.UserBid = default;
        }

        public void AddBalance(int amount)
        {

        }

    }
}
