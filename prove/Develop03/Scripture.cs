using System;

class Scripture
{
    private string reference;
    private string fullText;
    private List<HiddenWord> hiddenWords;

    public string Reference => reference;
    public bool AllWordsHidden => hiddenWords.Count == fullText.Split(' ').Length;

    public Scripture(string reference, string fullText)
    {
        this.reference = reference;
        this.fullText = fullText;
        this.hiddenWords = new List<HiddenWord>();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        string[] words = fullText.Split(' ');

        // Select a random word that is not already hidden
        string selectedWord;
        do
        {
            int index = random.Next(words.Length);
            selectedWord = words[index];
        } while (hiddenWords.Exists(word => word.Word == selectedWord));

        // Hide the selected word
        hiddenWords.Add(new HiddenWord(selectedWord));
    }

    public string GetVisibleText()
    {
        string visibleText = fullText;
        foreach (var hiddenWord in hiddenWords)
        {
            visibleText = visibleText.Replace(hiddenWord.Word, new string('_', hiddenWord.Word.Length));
        }
        return visibleText;
    }
}
