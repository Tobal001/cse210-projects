using Microsoft.VisualBasic;

public class Scripture 
{
    private Referance _referance;
    private List<Word> _words;  

    public Scripture(Referance referance, string text)
    {
        _referance = referance;
        _words = new List<Word>();
        
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));

        }
        
    }

    public void HideRandomWords(int NumberToHide)
    {
        
        int wordCount = _words.Count;
        Random random = new Random();
        if (NumberToHide > wordCount) NumberToHide = wordCount; 

        List<int> hiddenIndexs = new List<int>();
        while (hiddenIndexs.Count < NumberToHide)
        {
            int index = random.Next(0, wordCount);
            if (!hiddenIndexs.Contains(index) && !_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenIndexs.Add(index);
            }
        }
            var lastWords = _words.Where(word => !word.IsHidden()).ToList();
            if (lastWords.Count == 1)
            {
                lastWords[0].Hide();
            }

    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string GetDisplayText(bool showHint = false)
    {
        string displayText = _referance.GetDisplayText() + "\n";

        foreach (var word in _words)
        {
            displayText += word.GetDisplayText(showHint) + " ";

        }

        return displayText.TrimEnd();
    }


}