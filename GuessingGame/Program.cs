using System;
class Program
{
    static void Main()
    {
        // generating a random number
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("A random number has been generated between 1 and 100. ");
        int guess;

        

        do
        {
            // asking player to guess the number
            Console.Write("Please enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Guess again! ");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Too high. Guess again! ");
            }
            else
            {
                Console.WriteLine("Amazing! You've guessed correctly! ");   
                
            }

        }
        while (guess != targetNumber);
    }
}