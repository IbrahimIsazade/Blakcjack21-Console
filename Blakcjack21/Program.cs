using Blakcjack21.Models.Entities;
using Blakcjack21.Models.Exceptions;
using Blakcjack21.Models.Stable;
namespace Blakcjack21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player gambler = new Player();

            gambler.ShowHand();
            gambler.AddCard(2);
            gambler.ShowHand();
        }
    }
}
