public class Lecture : Event
{
    private string _speaker;
    public string Speaker;
    private int _capacity;
    public int Capacity;

    public Lecture(string title, string desc, DateTime date, string time, string address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        Speaker = speaker;
        _speaker = Speaker;
        Capacity = capacity;
        _capacity = Capacity;
    }

    public string GetSpeaker()
    { return _speaker; }

    public void SetSpeaker(string speaker)
    {
        Speaker = speaker;
        _speaker = Speaker;
    }

    public int GetCapacity()
    { return _capacity; }

    public void SetCapacity(int capacity)
    {
        Capacity = capacity;
        _capacity = Capacity;
    }
    public override string FullDetails()
    {
        return $"{Title} - {Speaker} - {Capacity} people max.\n{Desc}\n{Date.ToShortDateString()} - {Time}\n{Address}";
    }
}