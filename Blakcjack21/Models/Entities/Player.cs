using Blakcjack21.Models.Stable;

namespace Blakcjack21.Models.Entities
{
    internal class Player : User
    {
        UserHand hand = new UserHand();

        public void AddCard(int count)
        {
            hand.AddCard(count);
        }

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

        public void ShowHand()
        {
            hand.ShowHand();
        }
    }
}
