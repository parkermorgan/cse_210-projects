using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("What is your name? Type 'end' to end: ");
            string response = Console.ReadLine();
            
            if (response == "end")
            {
                Console.WriteLine("Fine. Go away then. :(");
                break;
            }
            else if (response != "end")
            {
                Console.WriteLine($"Hello {response}!");
                continue;
            }
        }
        
    }
}