using System;

namespace NumberGues
{
    class Program
    {
        static void Main(string[] args)
        {

            string appName = "Zgadywanie liczby";
            int appVersion = 1;
            string appAuthor = "Oskar Przybysz";

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"[{appName}] Wersja 0.{appVersion}, Author: {appAuthor}");

            Console.ResetColor();
        }
    }
}
