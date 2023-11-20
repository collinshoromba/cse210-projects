using System;

class ScriptureApp
{
    public static void Run()
    {
        // Create a library of scriptures
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        scriptureLibrary.LoadScriptures(); // You can implement loading from a file or other sources

        // Select a random scripture from the library
        Scripture selectedScripture = scriptureLibrary.GetRandomScripture();

        // Display the complete scripture
        DisplayScripture(selectedScripture);

        // Start hiding words until all words are hidden
        while (!selectedScripture.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords();
            Console.Clear();
            DisplayScripture(selectedScripture);
        }

        Console.WriteLine("All words are hidden. Program ends.");
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine($"{scripture.Reference}:");
        Console.WriteLine(scripture.GetVisibleText());
        Console.WriteLine();
    }
}
