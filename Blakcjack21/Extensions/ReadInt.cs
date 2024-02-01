using Blakcjack21.Models.Stable;
namespace Blakcjack21.Extensions
{
    internal static class ReadInt
    {
        public static int Read(string msg)
        {
            int value;
        l1:
            Print.Write($"{msg}: ", Paint.Blue);
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Print.WriteLine($"Please write a number", Paint.Red);
                goto l1;
            }
            return value;
        }
    }
}
