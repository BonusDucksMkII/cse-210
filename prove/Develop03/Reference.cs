public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verse = new List<int>();
    public string Book;
    public int Chapter;
    public List<int> Verses;

    public Reference(string BookName, int ChapterNum, List<int> VersesList)
    {
        _book = BookName;
        _chapter = ChapterNum;
        _verse = VersesList;

        Book = _book;
        Chapter = _chapter;
        Verses = _verse;
    }

    
}