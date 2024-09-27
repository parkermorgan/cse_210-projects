using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;


public class Entry 
{
    private string _dateText;
    private string _prompt;
    private string _entryText;
    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateText = theCurrentTime.ToShortDateString();
        
        Getprompt getprompt = new Getprompt();
        _prompt = getprompt.GetRandomPrompt();
       
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }
        
        public string GetDisplayText()
    {
        return $"Date: {_dateText} - Prompt: {_prompt} - Entry: {_entryText}";
    }
}    
    public class EntryManager
{
    public List<string> entries = new List<string>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry.GetDisplayText());
    }

    public void DisplayAllEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public static void SaveToFile(List<Entry>entries)
    {
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries )
            {
                outputFile.WriteLine(entry);
            }
        }
     

    }
}
    

 
