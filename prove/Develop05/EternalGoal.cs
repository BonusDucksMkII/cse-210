public class EternalGoal : Goal
{
    private bool _complete = false;
    public EternalGoal(string Name, string Description, int PointValue)
    {
        _points = PointValue;
        _description = Description;
        _name = Name;
    }
    public override bool GetComplete()
    {
        return true;
    }
    public override void SetComplete()
    {
        return;
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
        string endResult = $"03#{_name}#{_description}#{_points}";
        return endResult;
    }
}