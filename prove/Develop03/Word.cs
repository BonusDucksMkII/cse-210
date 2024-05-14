public class Word
{
    private string _text;
    private bool _hideWord;
    public string Text;
    public bool HideWord;

    public Word(string text)
    {
        _text = text;
        _hideWord = false;
    }

    public string GetText()
    {
        Text = _text;
        return Text;
    }
    
    public void SetText(string input)
    {
        _text = input;
        GetText();
    }

    public bool GetHide()
    {
        HideWord = _hideWord;
        return HideWord;
    }

    public void SetHide()
    {
        _hideWord = HideWord;
    }

    public void Hide()
    {
        HideWord = true;
        SetHide();
    }
}