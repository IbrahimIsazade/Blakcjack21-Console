using Blakcjack21.Models.Entities;
namespace Blakcjack21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game BlackJack = new Game(100);
            //BlackJack.Start();

            PlayerHand player = new PlayerHand();
            player.AddCard(2);
            foreach (var item in player)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
