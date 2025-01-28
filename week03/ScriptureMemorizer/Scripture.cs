public class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetDisplayText()
    {
        return $"{Reference}\n{string.Join(" ", Words.Select(w => w.GetDisplayText()))}";
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        var random = new Random();

        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
