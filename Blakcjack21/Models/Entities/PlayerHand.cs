using Blakcjack21.Extensions;
using Blakcjack21.Models.Stable;
using System.Collections;

namespace Blakcjack21.Models.Entities
{
    internal class PlayerHand : User, IEnumerable<KeyValuePair<string, CardRank>>
    {
        Dictionary<string, CardRank> cards = new Dictionary<string, CardRank>();
        SortedList<string, CardRank> userHand = new SortedList<string, CardRank>();

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
                userHand.Add(card, rank);
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

        public bool TryFind(CardRank rank)
        {
            if(!userHand.ContainsValue(rank))
            {
                return false;
            }
            return true;
        }

        public void ShowFirstCard()
        {
            if (userHand.Count == 0)
                Console.WriteLine("User doesn't have any cards");
            Print.Write($"{userHand.Keys.First()} ", Paint.Yellow);
            Console.WriteLine();
        }

        public int GetSumOfHand()
        {
            if (userHand.Count == 0)
                Console.WriteLine("User doesn't have any cards");
            int sum = 0;
            foreach (var card in userHand)
            {
                switch(card.Value)
                {
                    case CardRank.Two:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Three:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Four:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Five:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Six:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Seven:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Nine:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Ten:
                        sum += (byte)card.Value;
                        break;
                    case CardRank.Jack:
                        sum += 10;
                        break;
                    case CardRank.Queen:
                        sum += 10;
                        break;
                    case CardRank.King:
                        sum += 10;
                        break;
                    case CardRank.Ace:
                        sum += 11;
                        break;
                }
            }
            return sum;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
