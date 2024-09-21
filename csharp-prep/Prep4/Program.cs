using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter Number: ");

            string numberString = Console.ReadLine();
            userNumber = int.Parse(numberString);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {avg}");

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

    }
}