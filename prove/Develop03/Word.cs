public class Word
{   
    private string _text;
    private bool _isHidden;
    

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;

    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden() 
    {

        return _isHidden;
    }

    public string GetDisplayText(bool showHint = false) 
    {
        if (_isHidden)
        {
            
            return showHint ? _text[0] + new string('_', _text.Length - 1) : "_____";
        }
        else
        {
            return _text;
        }
    }

}