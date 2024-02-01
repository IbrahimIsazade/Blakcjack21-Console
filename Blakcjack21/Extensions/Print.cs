using Blakcjack21.Models.Stable;

namespace Blakcjack21.Extensions
{
    internal static class Print
    {
        public static void Write(string msg, Paint color)
        {
            var copyOfColor = Console.ForegroundColor;

            switch ((byte)color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            foreach (char letter in msg)
            {
                Thread.Sleep(25);
                Console.Write(letter);
            }
            Console.ForegroundColor = copyOfColor;
        }

        public static void WriteLine(string msg, Paint color)
        {
            Write($"{msg}\n", color);
        }
    }
}
