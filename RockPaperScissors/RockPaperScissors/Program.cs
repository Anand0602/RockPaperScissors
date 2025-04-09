//Creating rock Paper Scissors game
using System;
namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Enter your choice (rock, paper, scissors): ");
            string userChoice = Console.ReadLine().ToLower();
            Random random = new Random();
            int computerChoice = random.Next(0, 3);
            string[] choices = { "rock", "paper", "scissors" };
            string computerChoiceString = choices[computerChoice];
            Console.WriteLine($"Computer chose: {computerChoiceString}");
            if (userChoice == computerChoiceString)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoiceString == "scissors") ||
                     (userChoice == "paper" && computerChoiceString == "rock") ||
                     (userChoice == "scissors" && computerChoiceString == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}