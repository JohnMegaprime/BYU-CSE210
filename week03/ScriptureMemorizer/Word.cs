
public class Word
{
    public bool _isHidden;
    private string _wordText;

    public Word()
    {
        _wordText = "";
        _isHidden = false;
    }
    public Word(string wordString)
    {
        _wordText = wordString;
        _isHidden = false;

    }
    public Word(string wordString, bool hidden)
    {
        _wordText = wordString;
        _isHidden = hidden;

    }

    public void Hide()
    {
        _wordText = new string('_', _wordText.Length);
        _isHidden = true;
    }
    
    public string GetDisplayWord()
    {
        string word = _wordText;
        return word;
    }
}