using Snake_And_Ladder;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Snake and Ladder Game!");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();

        snake snake = new snake();
        ladder ladder = new ladder();
        char Exit = 'q';
        int[] playerPositions = { 0, 0 }; 
        Random random = new Random();
        int currentPlayer = 0;

        do
        {
            Console.WriteLine($"Player {currentPlayer + 1}'s turn");
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey();

            int randomNumber = random.Next(1, 7);
            Console.WriteLine($"Player {currentPlayer + 1} rolled a {randomNumber}!");

            playerPositions[currentPlayer] =playerPositions[currentPlayer]+ randomNumber;
            int tempPosition = playerPositions[currentPlayer];
            
            playerPositions[currentPlayer] = snake.Snake_Position(playerPositions[currentPlayer]);
            if (playerPositions[currentPlayer] < tempPosition)
            {
                Console.WriteLine($"Player {currentPlayer + 1} landed on a snake! Moves behind to position: {playerPositions[currentPlayer]}");
            }
            playerPositions[currentPlayer] = ladder.Ladder_Position(playerPositions[currentPlayer]);
            if (tempPosition < playerPositions[currentPlayer])
            {
                Console.WriteLine($"Player {currentPlayer + 1} landed on a ladder! Moves ahead to position: {playerPositions[currentPlayer]}");
            }
            if (playerPositions[currentPlayer] > 100)
            {
                playerPositions[currentPlayer] = playerPositions[currentPlayer] - randomNumber;
            }
            if (tempPosition == playerPositions[currentPlayer])
            {
                Console.WriteLine($"Player {currentPlayer + 1}'s current position is: {playerPositions[currentPlayer]}");
            }

            Console.WriteLine();

            if (playerPositions[currentPlayer] == 100)
            {
                Console.WriteLine($"Congratulations! Player {currentPlayer + 1} wins!");
                break; 
            }

            currentPlayer = 1 - currentPlayer;

        } while (Exit != Console.ReadKey().KeyChar);

        Console.WriteLine("Game Over!");
    }
}
