using System.IO;
public class GoalManager
{
    private int _score = 0;
    private List<Goal> _goalList;
    public List<Goal> GoalList;
    public GoalManager(List<Goal> GoalList, int Score)
    {
        _goalList = GoalList;
        _score = Score;
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter fs = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goalList)
            {
                fs.WriteLine(goal.GoalToSaveableString());
            }    
        }

    }
    public void LoadGoals(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split("#");
                if (data[0].Contains("01"))
                {
                    SimpleGoal newGoal = new SimpleGoal(data[1], data[2], int.Parse(data[3]));
                    if (int.Parse(data[4]) == 1)
                    {
                        newGoal.SetComplete();
                        _score += int.Parse(data[3]);
                    }
                    _goalList.Add(newGoal);
                }
                else if (data[0].Contains("02"))
                {
                    ChecklistGoal newGoal = new ChecklistGoal(data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
                    if (int.Parse(data[4]) == 1)
                    {
                        newGoal.SetComplete();
                        _score += int.Parse(data[3]);
                    }
                    _goalList.Add(newGoal);
                }
                else if (data[0].Contains("03"))
                {
                    EternalGoal newGoal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                    if (int.Parse(data[3]) == 1)
                    {
                        newGoal.SetComplete();
                        _score += int.Parse(data[2]);
                    }
                    _goalList.Add(newGoal);
                }
                else
                {
                    Console.WriteLine("No goals found in file; please check the file name.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("File name invalid, try again.");
        } 
    }
    public void DisplayGoals()
    {
        foreach (Goal goal in _goalList)
        {
            if (goal is SimpleGoal)
            {
                string test = 
                $"""
                    =========================
                           Simple Goal
                    -------------------------
                    Name: {goal.GetName()}
                    Description: {goal.GetDesc()}
                    Worth {goal.GetPoints()} points
                    =========================
                """;
                Console.WriteLine(test);
            }
            else if (goal is ChecklistGoal)
            {
                if (!goal.GetComplete())
                {
                    string test = 
                    $"""
                        =========================
                             Checklist Goal
                        -------------------------
                        Name: {goal.GetName()}
                        Description: {goal.GetDesc()}
                        Worth {goal.GetPoints()} points
                        Completed: {goal.GetTimesCompleted()}/{goal.GetTimesToComplete()} []
                        =========================
                    """;
                    Console.WriteLine(test);
                }
                else
                {
                    string test = 
                    $"""
                        =========================
                             Checklist Goal
                        -------------------------
                        Name: {goal.GetName()}
                        Description: {goal.GetDesc()}
                        Worth {goal.GetPoints()} points
                        Completed: {goal.GetTimesCompleted()}/{goal.GetTimesToComplete} [X]
                        =========================
                    """;
                    Console.WriteLine(test);
                }
            }
            else if (goal is EternalGoal)
            {
                string test = 
                $"""
                    =========================
                           Eternal Goal
                    -------------------------
                    {goal.GetName()}
                    {goal.GetDesc()}
                    {goal.GetPoints()}
                    Times completed: {goal.GetTimesCompleted()}
                    =========================
                """;
                Console.WriteLine(test);
            }
        }
    }
    public void DisplayInfo()
    {
        int i = 0;
        Console.WriteLine($"Total Points: {_score}");
        foreach (Goal goal in _goalList)
        {
            if (goal.GetComplete())
            {
                i++;
            }
        }
        Console.WriteLine($"Goals complete: {i}");
    }
    public void CreateGoal(Goal goal)
    {
        _goalList.Add(goal);
    }
    public void RecordEvent(Goal newGoal, Event newEvent)
    {
        newGoal.SetEvent(newEvent);
        newGoal.SetComplete();
        _score += newGoal.GetPoints();
    }
    public List<Goal> GetGoalList()
    {
        return _goalList;
    }
    public void SetGoalList(List<Goal> temp)
    {
         _goalList = temp;
    }
} 