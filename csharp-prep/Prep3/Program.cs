using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();
        int magicNumber = randomNum.Next(1,11);
        int guess;
        int guessesNum = 0;
        do {
            Console.WriteLine("What's the magic number?");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess) {
                Console.WriteLine("Higher");
            } else if (magicNumber < guess) {
                Console.WriteLine("Lower");
            }
            guessesNum += 1;
        } while (magicNumber != guess);
        Console.WriteLine($"You guessed it! You guessed {guessesNum} times.");
    }
}