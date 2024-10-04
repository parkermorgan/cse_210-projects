 using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nPlease select a program:\n1. Shape Calculator\n2. Item List\n3. Random Number Generator\n4. Quit");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                ShapeCalculator calculator = new ShapeCalculator();
                calculator.Start();
            }
            else if (selection == "2")
            {
                ItemListManager itemListManager = new ItemListManager();
                itemListManager.Start();
            }
            else if (selection == "3")
            {
                RandomNumManager randumNumManager = new RandomNumManager();
                randumNumManager.Start();
            }
            else if (selection == "4")
            {
                Console.WriteLine("Thank you for using the program.");
                break; // This ends the loop
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid option.");
            }
        }
    }
}
