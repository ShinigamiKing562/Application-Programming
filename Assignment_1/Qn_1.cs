using System;

class LuckyNumberGame
{
    static void Main()
    {
        Console.Write("Lets play a game. You'll enter a number and I'll divide it with a secret number. If the remainder is zero, it's a draw and you'll get one point. If it's odd you lose and I take 3 points from you and if it's even I lose and you get three points. We'll play for however many rounds you want and add up the score. If the final score is positive you win!");
        Console.Write("\nEnter the number of rounds you wish to play: ");
        int rounds = int.Parse(Console.ReadLine());
        int secretNumber = 6;
        int totalScore = 0;

        for (int i = 1; i <= rounds; i++)
        {
            Console.Write($"Enter your lucky number for round {i}: ");
            int luckyNumber = int.Parse(Console.ReadLine());
            int remainder = luckyNumber % secretNumber;

            if (remainder == 0)
            {
                Console.WriteLine("It's a draw! Score +1");
                totalScore += 1;
            }
            else if (remainder % 2 == 0)
            {
                Console.WriteLine("You win this round! Score +3");
                totalScore += 3;
            }
            else
            {
                Console.WriteLine("You lose this round! Score -3");
                totalScore -= 3;
            }
        }

        Console.WriteLine($"\nFinal Score: {totalScore}");
        if (totalScore > 0)
        {
            Console.WriteLine("Congratulations! You win the game!");
        }
        else
        {
            Console.WriteLine("You lost the game! Better luck next time.");
        }
    }
}
