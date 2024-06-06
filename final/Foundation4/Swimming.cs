using System.Data;

public class Swimming : Activity
{
    private int _laps;
    public int Laps;

    public Swimming(DateTime date, int time, int laps)
    {
        SetDate(date);
        SetTime(time);
        SetLaps(laps);
    }

    public double GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        Laps = laps;
        _laps = Laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
}