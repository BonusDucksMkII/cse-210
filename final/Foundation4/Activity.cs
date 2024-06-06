public abstract class Activity
{
    private DateTime _date;
    private int _overallTime;
    public DateTime Date;
    public int OverallTime;

    public virtual double GetDistance()
    {
        return 1 * 60 / _overallTime;
    }
    public virtual double GetSpeed(double distance)
    {
        return distance / _overallTime * 60;
    }
    public virtual double GetPace(double speed)
    {
        return 60 / speed;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        Date = date;
        _date = Date;
    }

    public double GetTime()
    {
        return _overallTime;
    }

    public void SetTime(int time)
    {
        OverallTime = time;
        _overallTime = OverallTime;
    }

    public string GetSummary()
    {
        string newStr = $"{Date.ToShortDateString()} - {GetType()}: Distance {GetDistance()} km, Speed {GetSpeed(GetDistance())} kph, Pace {GetPace(GetSpeed(GetDistance()))} min per km";
        return newStr;
    }
}