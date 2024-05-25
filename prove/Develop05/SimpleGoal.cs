public class SimpleGoal : Goal
{
    private bool _complete = false;

    public SimpleGoal(string Name, string Description, int Points)
    {
        _name = Name;
        _description = Description;
        _points = Points;
    }
    public override void SetComplete()
    {
        _complete = true;
        Console.WriteLine("Congrats! You completed your goal.");
    }
    public override bool GetComplete()
    {
        return _complete;
    }
    public override int GetTimesCompleted()
    {
        throw new NotImplementedException();
    }
    public override int GetTimesToComplete()
    {
        throw new NotImplementedException();
    }
    public override string GoalToSaveableString()
    {
        int t = _complete ? 1 : 0;
        string endResult = $"01#{_name}#{_description}#{_points}#{t}";
        if (_event != null)
        {
            endResult += $"#{_event.getDate()}#{_event.getDesc()}";
        }
        return endResult;
    }
}