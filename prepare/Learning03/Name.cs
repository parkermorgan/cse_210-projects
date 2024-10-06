using System;

public class Name
{
    public void Start()
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        Console.Write("What year were you born? ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine($"{fname} {lname}, you were born in {year}.");
    }
    
}