public class Scripture
{
    private readonly Reference _reference;
    private readonly Word[] _words;
    private readonly Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        _words = new Word[wordArray.Length];
        for (int i = 0; i < wordArray.Length; i++)
        {
            _words[i] = new Word(wordArray[i]);
        }
        _random = new Random();
    }

    public bool HideRandomWord()
    {
        var visibleWords = _words.Where(w => !w.Hidden).ToList();
        if (visibleWords.Count == 0)
            return false;

        var randomIndex = _random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hide();
        return true;
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"\nReference: {_reference}");
        foreach (Word word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine("\n");
    }
}

