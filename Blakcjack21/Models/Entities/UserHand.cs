using Blakcjack21.Models.Stable;
using System;
namespace Blakcjack21.Models.Entities
{
    internal class UserHand
    {
        Card[] cards = Array.Empty<Card>();

        public void AddCard(Card card)
        {
            if(cards.Length < 3)
            {
                byte len = (byte)cards.Length;
                Array.Resize(ref cards, len);
                cards[len] = card;
                return;
            }
            
        }
    }
}
