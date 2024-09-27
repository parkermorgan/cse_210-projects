using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        EntryManager entryManager = new EntryManager();
        bool looping = true;

        while (looping)
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            string option = Console.ReadLine();

            if (option == "1")
            {
                Entry entry = new Entry();
                entryManager.AddEntry(entry);
            }
            else if (option == "2")
            {
                entryManager.DisplayAllEntries();
            }
            else if (option == "4")
            {

                entryManager.SaveToFile(entr);
                Console.WriteLine("Entries saved to file.");
            }
            else if (option == "5")
            {
                Console.WriteLine("Thank you for using the journal!");
                looping = false;
            }
        }
    }
}