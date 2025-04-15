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

            while (playAgain)
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") 
                {
                    Console.WriteLine("Enter ROCK, PAPER, OR SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }
                Console.WriteLine(player);

            }


        }
    }
}