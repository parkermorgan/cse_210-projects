using System;
using System.Net;
using System.Security.Cryptography;

public class RandomNumManager
{
    public void Start()
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
                Console.WriteLine("Congrats! You guessed the number!");
                Console.Write("Do you want to play again? ");
                response = Console.ReadLine();
                number = randomGenerator.Next(1, 101);
            }  
        }
    }

}