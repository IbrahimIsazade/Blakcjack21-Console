using Blakcjack21.Extensions;
using Blakcjack21.Models.Stable;
using System.Collections;

namespace Blakcjack21.Models.Entities
{
    internal class PlayerHand : User, IEnumerable<Card>
    {
        Card[] cards = Array.Empty<Card>();

        public void AddCard(int count = 1)
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

        public IEnumerator<Card> GetEnumerator()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                yield return cards[i];
            }
        }

        public void ShowHand()
        {
            if (cards.Length == 0)
                Console.WriteLine("User doesn't have any cards");
            Print.WriteLine($"Your hand now is:", Paint.Green);
            foreach (Card card in cards)
            {
                Print.Write($"{card} ", Paint.Yellow);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
