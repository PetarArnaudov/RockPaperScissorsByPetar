using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {   
            // That's my first game project added to GitHub (test)
            
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            bool endGame = false;
            int playerResult = 0;
            int computerResult = 0;


            while (!endGame)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Try again!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    continue;
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


                Console.ForegroundColor = ConsoleColor.Yellow;
                if (playerMove == computerMove)
                {
                    Console.WriteLine("Draw!");
                }
                else if ((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock))
                {
                    Console.WriteLine("You lose!");
                    computerResult++;
                }
                else
                {
                    Console.WriteLine("You win!");
                    playerResult++;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"( Result Player: {playerResult} vs Computer : {computerResult} )");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pres [y] if you want to play again or [x] to close the game: ");
                string playAgain = Console.ReadLine();

                if (playAgain == "x")
                {
                    endGame = true;
                }

            }

            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
