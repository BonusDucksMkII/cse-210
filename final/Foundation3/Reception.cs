public class Reception : Event
{
    private string _rsvpEmail;
    public string RsvpEmail;

    public Reception(string title, string desc, DateTime date, string time, string address, string rsvp) : base(title, desc, date, time, address)
    {
        _rsvpEmail = rsvp;
    }

    public override string FullDetails()
    {
        return $"{Title} - {Desc}\n{Date.ToShortDateString()} - {Time}\n{Address}\nRSVP at {RsvpEmail}";
    }

    public void SetRsvp(string rsvp)
    {
        RsvpEmail = rsvp;
        _rsvpEmail = RsvpEmail;
    }

    public string SetRsvp()
    {
        return _rsvpEmail;
    }
}