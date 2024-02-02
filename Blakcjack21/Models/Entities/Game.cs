using Blakcjack21.Extensions;
using Blakcjack21.Models.Stable;

namespace Blakcjack21.Models.Entities
{
    internal class Game
    {
        // Players' hands
        PlayerHand gamblerHand = new PlayerHand();
        PlayerHand dealerHand = new PlayerHand();

        // User's properties
        public int UserBid { get; private set; }
        public int UserBalance { get; private set; }

        public Game(int userBalance)
        {
            this.UserBalance = userBalance;
            this.UserBid = default;
            gamblerHand.AddCard(2);
            dealerHand.AddCard(2);
        }

        public void Hit()
        {
            gamblerHand.AddCard();
            Print.Write($"Your hand: ", Paint.Green);
            foreach(var card in gamblerHand)
            {
                Print.Write($"{card} ", Paint.Yellow);
            }
            Console.WriteLine();
            Print.Write($"Your balace: ", Paint.Green);
            Print.Write(UserBalance+"\n", Paint.Yellow);
        }

        public void DealerHit()
        {
            dealerHand.AddCard();
        }

        public void Double()
        {
            this.UserBid *= 2;
            gamblerHand.AddCard();

        }

        public void Pass()
        {
            this.UserBalance = default;
            this.UserBid = default;
        }


        // == The game logic ==

        public Actions Menu()
        {
            Print.WriteLine("\n--- Select an action ---", Paint.White);
            Array actions = Enum.GetValues(typeof(Actions));

            foreach (var action in actions)
            {
                Print.WriteLine($"{(byte)action}. {action}", Paint.Yellow);
            }

            int userChoise = ReadInt.Read("Choose from list");
            Actions userAction = (Actions)Enum.ToObject(typeof(Actions), userChoise);
            Console.Clear();
            return userAction;
        }

        public void DoAction()
        {
            Actions userAction = Menu();
            switch ((byte)userAction)
            {
                case 1:
                    Hit();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
            }
        }

        public void Start()
        {
            #region starting words
            Print.WriteLine("Welcome to Blackjack on console !", Paint.Blue);
            Thread.Sleep(500);
            Print.WriteLine("Let's start the game", Paint.Blue);
            Thread.Sleep(1500);
            Console.Clear();
            #endregion

            gamblerHand.ShowHand();
            Print.Write($"Your balace: ", Paint.Green);
            Print.Write(UserBalance.ToString(), Paint.Yellow);
            DoAction();
        }
    }
}
