using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace RockPaperScissors__lt_LoganWinscher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RockPaperSciccorsLizardSpock();
        }
        private static void RockPaperSciccorsLizardSpock()
        {
            string[] choices = { "Rock", "Paper", "Sciccors", "Lizard", "Spock"};
            Random rnd = new Random();
            int playerWins = 0;
            int computerWins = 0;
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("First to 5 wins!");

            
            string computerChoice = choices[rnd.Next(choices.Length)];
            string playerChoice = choices[rnd.Next(choices.Length)];

            while (playerWins < 5 && computerWins < 5)
            {
                Console.WriteLine("\nEnter your choice (rock, paper, scissors, lizard, spock)");

                if (Array.IndexOf(choices, playerChoice) == -1)
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
                }
                Console.WriteLine("Computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It is a tie! ");
                }
                else if (playerChoice == "Rock" && computerChoice == "Scissors" || computerChoice == "Lizard" ||
                        playerChoice == "Paper" && computerChoice == "Rock" || computerChoice == "Spock" ||
                        playerChoice == "Scissors" && computerChoice == "Paper" || computerChoice == "Lizard" ||
                        playerChoice == "Lizard" && computerChoice == "Spock" || computerChoice == "Paper" ||
                        playerChoice == "Spock" && computerChoice == "Scissors" || computerChoice == "Rock")
                {
                    Console.WriteLine("Player wins the round");
                    playerWins++;
                }
                else
                {
                    Console.WriteLine("Computer wins the round!");
                    computerWins++;
                }
                Console.WriteLine("Score - You: {playerWins} | computer: {computerWins}");
            }
            if(playerWins== 5)
            {
                Console.WriteLine("\n congratulations! you won the game!");
            }
            else
            {
                Console.WriteLine("\n computer has won the game! Better luck next time");
            }
        }
    }
}
