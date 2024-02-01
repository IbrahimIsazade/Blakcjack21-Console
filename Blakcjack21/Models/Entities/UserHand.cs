using Blakcjack21.Models.Stable;
using System;
namespace Blakcjack21.Models.Entities
{
    internal class UserHand
    {
        Card[] cards = Array.Empty<Card>();

        public void AddCard(int count)
        {
            Random r = new Random();
            Array allCards = Enum.GetValues(typeof(Card));
            byte len = (byte)cards.Length;
            Array.Resize(ref cards, len + count);
            for (int i = 0; i < count; i++)
            {
                byte rInt = (byte)r.Next(0, allCards.Length);
                cards[len + i] = (Card)allCards.GetValue(rInt)!;
            }
        }

        public void ShowHand()
        {
            if(cards.Length == 0)
                Console.WriteLine("User doesn't have any cards");
            foreach (Card item in cards)
            {
                Console.WriteLine($"{(byte)item}. {item}");
            }
        }
    }
}
