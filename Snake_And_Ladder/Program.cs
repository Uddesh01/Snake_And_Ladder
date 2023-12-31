using Snake_And_Ladder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Snake and Ladder Game!");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();

        snake snake = new snake();
        ladder ladder = new ladder();
        char userInput;
        char Exit = 'q';
        int CurrentPosition = 0;
        Random random = new Random();

        do
        {
            if (CurrentPosition <= 100)
            {
                int randomNumber = random.Next(1, 7);
                Console.WriteLine($"You rolled a {randomNumber}!");

                CurrentPosition += randomNumber;
                int previousPosition = CurrentPosition;
                CurrentPosition = snake.Snake_Position(CurrentPosition);
                if (CurrentPosition < previousPosition)
                {
                    Console.WriteLine("You landed on a snake! Moves behind to position:{0}", CurrentPosition);
                }
                CurrentPosition = ladder.Ladder_Position(CurrentPosition);
                if (previousPosition < CurrentPosition)
                {
                    Console.WriteLine("Player landed on a ladder! Moves ahead to position:{0}", CurrentPosition);

                }
                if (CurrentPosition > 100)
                {
                    CurrentPosition -= randomNumber;
                }
                if (previousPosition == CurrentPosition)
                {
                    Console.WriteLine("Your current position is:{0}", CurrentPosition);
                }
                

               
                Console.WriteLine();

                if (CurrentPosition == 100)
                {
                    Console.WriteLine("Congratulations! You win!");
                }
            }

            if (CurrentPosition != 100)
            {
                Console.WriteLine("Press any key to continue or 'q' to exit:");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            else
            {
                userInput = 'q';
            }

        } while (Exit != userInput);
    }
}
