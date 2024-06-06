public class Running : Activity
{
    private int _distance;
    public int Distance;

    public Running(DateTime date, int time, int distance)
    {
        SetDate(date);
        SetTime(time);
        SetDistance(distance);
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(int distance)
    {
        Distance = distance;
        _distance = Distance;
    }
}