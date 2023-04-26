using System;

class Program
{

    static void MagicNumberGame()
    {
        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1, 100);
        int response;
        int guessCount = 0;
        string playAgain = "";

        do
        {
            Console.Write("What is your guess?: ");
            response = int.Parse(Console.ReadLine());
            guessCount ++; 

            
            if(response > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(response < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        
            
        }while (response != magicNumber);
        
        Console.WriteLine("Correct!");
        Console.WriteLine($"It took you {guessCount} guesses!");
        Console.Write("Do you want to play again?(yes/no): ");
        playAgain = Console.ReadLine().ToLower();

        if(playAgain == "yes")
        {
            MagicNumberGame();
        }

    }
    static void Main(string[] args)
    {
        MagicNumberGame();
        
    }
}