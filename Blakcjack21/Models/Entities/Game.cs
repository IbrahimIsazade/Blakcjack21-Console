﻿using Blakcjack21.Extensions;
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
            Print.WriteLine($"You hit", Paint.Blue);
            gamblerHand.ShowHand();
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

            #region Tutorial
            char choise;
            Print.Write("If you want to see tutorial ? (y/n): ", Paint.Yellow);
        l1:
            if(!char.TryParse(Console.ReadLine(), out choise))
            {
                Print.WriteLine("You've to write `y` or `n`", Paint.Red);
                Thread.Sleep(1000);
                Console.Clear();
                goto l1;
            }

            if (choise == 'y')
            {
                Print.WriteLine("Objective: The goal of blackjack is to beat the dealer’s hand without going over 21.\r\n\r\nCard Values:\r\n\r\nFace cards (Kings, Queens, Jacks) are worth 10 points.\r\nAces are worth 1 or 11 points, whichever makes a better hand.\r\nAll other cards are worth their face value.\r\nGameplay:\r\n\r\nEvery player starts with two cards, one of the dealer’s cards is hidden until the end.\r\nTo ‘Hit’ is to ask for another card. To ‘Stand’ is to hold your total and end your turn.\r\nIf you go over 21, you bust, and the dealer wins regardless of the dealer’s hand.\r\nIf you are dealt 21 from the start (Ace & 10), you have a blackjack.\r\nDealer will hit until his/her cards total 17 or higher.\r\nDoubling is like a hit, only the bet is doubled, and you only get one more card.\r\nSplit can be done when you have two of the same card - the pair is split into two hands.\r\nYou can only double/split on the first move, or first move of a hand created by a split.\r\nWinning:\r\n\r\nYou win if you do not bust and your total is higher than the dealer’s total.\r\nYou win if the dealer busts and you do not bust.\r\nIf you and the dealer have the same total, it is a ‘push’ and the bet is returned to you.", Paint.White);
                Print.WriteLine("Press any button to close.", Paint.Red);
                Console.ReadKey();
                Console.Clear();
            }
            else if(choise == 'n') { }
            else { goto l1; }
            #endregion

            #region Showing gambler's info
            gamblerHand.ShowHand();
            Print.Write($"Your balace: ", Paint.Green);
            Print.Write(UserBalance.ToString() + "\n", Paint.Yellow);
            Print.Write($"Your bid: ", Paint.Green);
            Print.Write(UserBid.ToString() + "\n", Paint.Yellow);
            #endregion

            DoAction();

            Console.WriteLine("END");
        }
    }
}
