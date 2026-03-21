
using System.Dynamic;
using System.Security.Cryptography;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;

        string[] words = scriptureText.Split(' ');

        foreach (string wordText in words)
        {
            _words.Add(new Word(wordText));
        }
    }

    public string GetDisplayText()
    {
        string verseText = "";
        foreach (Word word in _words)
        {
            verseText += $"{word.GetDisplayWord()} ";

        }
        string fullText = $"{_reference.GetDisplayText()} {verseText}";

        return fullText;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int randomNumber = 0;
        
        for (int i = 0; i < numberToHide; i++)
        {
            randomNumber = random.Next(0, _words.Count());
            _words[randomNumber].Hide();
        }



    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = _words.All(Word => Word._isHidden);

        return completelyHidden;
    } 


}