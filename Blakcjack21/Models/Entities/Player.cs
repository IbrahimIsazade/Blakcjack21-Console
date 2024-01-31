using Blakcjack21.Models.Stable;

namespace Blakcjack21.Models.Entities
{
    internal class Player : User
    {
        Card[] cards = Array.Empty<Card>();

        public void Bet(int amount)
        {
            throw new NotImplementedException();
        }

        public void Double()
        {
            throw new NotImplementedException();
        }

        public void Hit()
        {
            throw new NotImplementedException();
        }

        public void Pass()
        {
            throw new NotImplementedException();
        }
    }
}
