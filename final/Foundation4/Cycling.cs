public class Cycling : Activity
{
    private int _speed;
    public int Speed;

    public Cycling(DateTime date, int time, int speed)
    {
        SetDate(date);
        SetTime(time);
        SetSpeed(speed);
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(int speed)
    {
        Speed = speed;
        _speed = Speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() * 60 / OverallTime;
    }
}