using System;

namespace rockpapaerscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, OR SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                int randomNum = random.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                //Console.WriteLine(player);
                //Console.WriteLine("Player: " + player);
                //Console.WriteLine("Computer: " + computer);
                Console.WriteLine("You: " + player);
                Console.WriteLine("Computer: " + computer);
                if (player == "ROCK" && computer == "SCISSORS" || player == "PAPER" && computer == "ROCK" || player == "SCISSORS" && computer == "PAPER")
                {
                    Console.WriteLine("You Win!");
                }
                else if (player == computer)
                {
                    Console.WriteLine("It's a draw!");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }
                Console.WriteLine("Would you like to play again (Y/N)?");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}