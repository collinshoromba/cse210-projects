using System;
class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();


        if (!File.Exists(filename))
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    entries.Add(new JournalEntry(parts[1], parts[2], parts[0]));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    
    public void DisplayAverageResponseLength()
    {
        double averageLength = entries.Select(entry => entry.Response.Length).Average();
        Console.WriteLine($"Average Response Length: {averageLength:F2} characters");
    }
}