using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blakcjack21.Models.Entities
{
    internal interface User
    {
        public void Bet(int amount);
        public void Hit();
        public void Double();
        public void Pass();
    }
}
