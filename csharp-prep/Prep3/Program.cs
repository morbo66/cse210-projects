using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        //Console.Write("what is the magic number? ");
        //string magicNumString = Console.ReadLine();
        
        Random randomGenerator = new Random();
        
        int magicNumber = randomGenerator.Next(1,101);
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }while (magicNumber != guess);

        Console.WriteLine("You guessed it!");

    }
}