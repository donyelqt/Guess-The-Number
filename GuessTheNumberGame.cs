using System;

namespace GuessTheNumber
{
 class Program
 {
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int userGuess;
        string playAgain;

        Console.WriteLine("The program has generated a random number between 0 and 100.");

        do
        {
            Console.Write("Enter your guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess < 0 || userGuess > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                continue;
            }

            int difference = Math.Abs(randomNumber - userGuess);

            if (difference > 20)
            {
                Console.WriteLine("Very far.");
            }
            else if (difference > 10)
            {
                Console.WriteLine("Far.");
            }
            else
            {
                Console.WriteLine("Close.");
            }

            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
  }
}
