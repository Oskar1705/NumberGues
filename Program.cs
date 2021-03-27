using System;

namespace NumberGues
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            string userName = GetUserName();

            GreetUser(userName); 

            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            string test = "123";

            bool correctAnswer = false;

            Console.WriteLine("Zgdanij wylosowaną liczbę z przedziału od 1 do 10");

            while (correctAnswer == false)
            {
                string input = Console.ReadLine();

                int guess;

                bool isNumber = int.TryParse(input, out guess);

                if (!isNumber)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę!");
                    Console.ResetColor();
                    continue;
                }

                if (guess < 1 || guess > 10)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę w przedziale od 1 do 10");
                    Console.ResetColor();
                    continue;
                }

                if (guess < correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Błędna odpowiedź :(");
                    Console.ResetColor();
                }

                else if (guess > correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Błędna liczba, wylosowana liczba jest mniejsza");
                    Console.ResetColor();
                }
                else
                {
                    correctAnswer = true;
                    PrintColorMessage(ConsoleColor.Green, "Brawo! Odpowiedź jest prawidłowa");
                    Console.ResetColor();
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Zgadywanie liczby";
            int appVersion = 1;
            string appAuthor = "Oskar Przybysz";

            string info = $"[{appName}] Wersja 0.{appVersion}, Author: {appAuthor}";

            PrintColorMessage(ConsoleColor.Magenta, info);


            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.ResetColor();
        }

        static string GetUserName()
        {
            Console.WriteLine("Jak masz na imię ?");

            string inputUserName = Console.ReadLine();

            return inputUserName;
        }

        static void GreetUser(string userName)
        {
            string greet = $"Powodzenia {userName}, odgadnij liczbę...";

            PrintColorMessage(ConsoleColor.Blue, greet);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

        }
    }
}
