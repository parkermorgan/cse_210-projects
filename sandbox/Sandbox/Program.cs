using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nPlease select a program:\n1. Shape Calculator\n2. Item List\n3. Quit");
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
