public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected Event _event;
    private enum _goalType
    {
        
    }
    public abstract void SetComplete();
    public abstract bool GetComplete();
    public abstract int GetTimesToComplete();
    public abstract int GetTimesCompleted();
    public abstract string GoalToSaveableString();
    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDesc()
    {
        return _description;
    }
    public virtual void SetEvent(Event newEvent)
    {
        _event = newEvent;
    }
}