using System;

public class DisplayAll
{
    public List<string> entries = new List<string>();

    public void AddEntry (Entry entry)
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
}
