using System;
using System.Collections.Generic;

public class ItemList
{
    private List<string> items;

    public ItemList() // Constructor should not have a return type
    {
        items = new List<string>();
    }

    public void AddItem(string item)
    {
        items.Add(item);
        Console.WriteLine($"'{item}' has been added to the list.");
    }

    public void DisplayItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            Console.WriteLine("\nYour list contains the following items:");
            foreach (var item in items)
            {
                Console.WriteLine("- " + item);
            }
        }
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}
