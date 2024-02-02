using Blakcjack21.Extensions;
using Blakcjack21.Models.Stable;
using System.Collections;

namespace Blakcjack21.Models.Entities
{
    internal class PlayerHand : User, IEnumerable<KeyValuePair<string, CardRank>>
    {
        Dictionary<string, CardRank> cards = new Dictionary<string, CardRank>();
        List<KeyValuePair<string, CardRank>> userHand = new List<KeyValuePair<string, CardRank>>();

        public PlayerHand()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardRank value in Enum.GetValues(typeof(CardRank)))
                {
                    string card = suit.ToString() + value.ToString();
                    cards.Add(card, value);
                }
            }
        }

        public void AddCard(int count = 1)
        {
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                Suit suit = (Suit)Enum.ToObject(typeof(Suit), r.Next(1, 5));
                CardRank rank = (CardRank)Enum.ToObject(typeof(CardRank), r.Next(2, 12));
                string card = suit.ToString() + rank.ToString();
                KeyValuePair<string, CardRank> pair = new KeyValuePair<string, CardRank>(card, rank);
                userHand.Add(pair);
            }
        }

        public IEnumerator<KeyValuePair<string, CardRank>> GetEnumerator()
        {
            return userHand.GetEnumerator();
        }

        public void ShowHand()
        {
            if (userHand.Count == 0)
                Console.WriteLine("User doesn't have any cards");
            Print.Write($"Your hand: ", Paint.Green);
            foreach (var card in userHand)
            {
                Print.Write($"{card.Key} ", Paint.Yellow);
            }
            Console.WriteLine();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
