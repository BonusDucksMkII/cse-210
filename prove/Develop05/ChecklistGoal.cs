public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesToComplete;
    private int _bonusPoints;
    private bool _complete = false;
    private List<Event> _eventList = new List<Event>();
    public ChecklistGoal(string Name, string Description, int Points, int TimeToComplete, int BonusPoints, int TimesCompleted = 0)
    {
        _name = Name;
        _description = Description;
        _points = Points;
        _timesToComplete = TimeToComplete;
        _bonusPoints = BonusPoints;
        _timesCompleted = TimesCompleted;
    }
    
    public override void SetComplete()
    {
        _timesCompleted++;
        if (_timesCompleted == _timesToComplete)
        {
            _complete = true;
            Console.WriteLine("Congrats! You completed your goal.");
        }   
    }
    public override bool GetComplete()
    {
        return _complete;
    }
    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public override int GetTimesToComplete()
    {
        return _timesToComplete;
    }
    public override void SetEvent(Event Event)
    {
        _eventList.Add(Event);
    }
    public override string GoalToSaveableString()
    {
        int t = _complete ? 1 : 0;
        string endResult = $"02#{_name}#{_description}#{_points}#{t}#{_bonusPoints}#{_timesToComplete}#{_timesCompleted}";
        foreach (Event q in _eventList)
        {
            endResult += $"#{q.getDate()}#{q.getDesc()}$";
        }
        return endResult;
    }
}