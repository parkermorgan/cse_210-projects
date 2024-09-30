using System;

public class ItemListManager
{
    private ItemList itemList;

    public ItemListManager() // Constructor should not have a return type
    {
        itemList = new ItemList();
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Please enter an item to add to the list (or type 'view' to see the list, or 'exit' to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break; // Exit the loop if user types 'exit'
            }
            else if (input.ToLower() == "view")
            {
                itemList.DisplayItems(); // Display the list
                continue; // Go back to the start of the loop
            }

            itemList.AddItem(input); // Append the item to the list
        }

        Console.WriteLine("Thank you for using the item list manager!");
    }
}
