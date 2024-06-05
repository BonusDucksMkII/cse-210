using System.ComponentModel.Design;

public abstract class Event
{
    private string _title;
    public string Title;
    private string _desc;
    public string Desc;
    private DateTime _date;
    public DateTime Date;
    private string _time;
    public string Time;
    private string _address;
    public string Address;

    public Event(string title, string desc, DateTime date, string time, string address)
    {
        Title = title;
        _title = Title;
        Desc = desc;
        _desc = Desc;
        Date = date;
        _date = Date;
        Time = time;
        _time = Time;
        Address = address;
        _address = Address;
    }

    public string GetTitle()
    { return _title; }

    public void SetTitle(string title)
    {
        Title = title;
        _title = Title;
    }

    public string GetDesc()
    { return _title; }

    public void SetDesc (string desc)
    {
        Desc = desc;
        _desc = Desc;
    }

    public DateTime GetDate()
    { return _date; }

    public void SetDate(DateTime date)
    {
        Date = date;
        _date = Date;
    }

    public string GetTime()
    { return _time; }

    public void SetTime(string time)
    {
        Time = time;
        _time = Time;
    }

    public string GetAddress()
    { return _address; }

    public void SetAddress(string address)
    {
        Address = address;
        _address = Address;
    }

    public string StandardDetails()
    {
        return $"{Title} - {Desc}\n{Date.ToShortDateString()} - {Time}\n{Address}";
    }

    public string ShortDesc()
    {
        return $"{GetType()}\n{Title}\n{Date.ToShortDateString()}";
    }

    public abstract string FullDetails();
}