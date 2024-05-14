public class Scripture
{
    private Reference _reference;
    private List<Word> _text;
    public Reference Reference;
    public List<Word> Text;
    public Scripture(Reference scripReference, string scripText)
    {
        _reference = scripReference;
        _text = SplitWords(scripText);
        Text = getText();
        Reference = getReference();
    }

    public void HideWords()
    {
        Random rand = new Random();
        rand.Next();
    }

    static List<Word> SplitWords(string inputText){
        List<Word> outputText = new List<Word>();
        string[] splits = inputText.Split(' ');
        foreach (string word in splits)
        {
            Word next = new(word);
            outputText.Add(next);
        }

        return outputText;
    }

    public Reference getReference()
    {
        return _reference;
    }

    public List<Word> getText()
    {
        return _text;
    }
}