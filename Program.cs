using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "Rock", "Paper", "Scissors" };

            while(true)
            {
                Console.WriteLine("Welcome to the Rock-Paper-Scissors game!");
                Console.WriteLine("Make your choice: ");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("0. Quit");

                string userInput = Console.ReadLine();

                if (userInput == "0")
                    break;

                int userChoiceIndex;
                if (!int.TryParse(userInput, out userChoiceIndex) || userChoiceIndex < 1 || userChoiceIndex > 3)
                {
                    Console.WriteLine("Invalid input! Please try again.");
                    continue;
                }

                string userChoice = choices[userChoiceIndex - 1];
                string computerChoice = choices[new Random().Next(0, 3)];

                Console.WriteLine("Computer's choice: " + computerChoice);

                ShowResult(userChoice, computerChoice);
            }
        }

        static void ShowResult(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
                return;
            }

            bool userWins = (userChoice == "Rock" && computerChoice == "Scissors") ||
                            (userChoice == "Paper" && computerChoice == "Rock") ||
                            (userChoice == "Scissors" && computerChoice == "Paper");

            if (userWins)
            {
                Console.WriteLine("You are the WINNER!");
            }
            else
            {
                Console.WriteLine("You are the LOSER!");
            }
        }
    }
}



















