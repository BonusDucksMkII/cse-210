public class Event
{
    private string _date;
    private string _description;

    public Event(string Date, string Description)
    {
        _date = Date;
        _description = Description;
    }

    public void setDate(string Description)
    {
        _description = Description;
    }

    public void SetDescription(string Date)
    {
        _date = Date;
    }
    public string getDate()
    {
        return _date;
    }
    public string getDesc()
    {
        return _description;
    }
}