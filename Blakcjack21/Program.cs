using Blakcjack21.Models.Entities;
namespace Blakcjack21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game BlackJack = new Game(100);
            BlackJack.Start();
            Console.ReadKey();
        }
    }
}
