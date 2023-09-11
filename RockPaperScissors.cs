using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid input! Try again!");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            if (computerRandomNumber == 1)
            {
                computerMove = rock;
            }
            else if (computerRandomNumber == 2)
            {
                computerMove = paper;
            }
            else if (computerRandomNumber == 3)
            {
                computerMove = scissors;
            }

            Console.WriteLine($"The computer chose {computerMove}.");

            if (playerMove == computerMove)
            {
                Console.WriteLine("Draw!");
            }
            else if ((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock))
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }

            
        }
    }
}
