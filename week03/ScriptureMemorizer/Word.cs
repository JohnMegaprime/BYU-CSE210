
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
        List<string> characters = [];
        foreach (char letter in _wordText)
        {
            characters.Add("_");
        }
        _wordText = string.Join("",characters);
        _isHidden = true;
    }
    
    public string GetDisplayWord()
    {
        string word = _wordText;
        return word;
    }
}