using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        while (response == "yes")
        {
            Console.Write("What is the magic number? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                Console.Write("Do you want to continue? ");
                response = Console.ReadLine();
                number = randomGenerator.Next(1, 101);
            }
        
        }


    }
}