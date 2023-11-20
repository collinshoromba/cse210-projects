using System;

class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
    }

    public void LoadScriptures()
    {
        // scriptures that the user will be able to play with and i can put as many scriptures in this section.
        scriptures.Add(new Scripture("1 Nephi 3:7", "And it came to pass that I, Nephi, said to my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them..."));
        scriptures.Add(new Scripture("Doctrine & Covenants 11:21", "Trust in the Lord with all your heart..."));
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}
