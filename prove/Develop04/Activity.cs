using System.Net.Mail;

public class Activity
{
    private string _activityName;
    private string _description;
    private double _time;
    private string _messageStart;
    private string _messageEnd;

    public Activity(string activityName, string description, string messageStart, string messageEnd)
    {
        _activityName = activityName;
        _description = description;
        _messageStart = messageStart;
        _messageEnd = messageEnd;
    }

    public void ActivityStart()
    {
        Console.WriteLine($"{_activityName}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long are you going to do this for in seconds? ");
        string t = Console.ReadLine();
        _time = Convert.ToDouble(t);        
        Console.WriteLine("Press any key when you are ready to start.");
        Console.ReadKey();
    }

    public void ActivityEnd()
    {
        Console.WriteLine($"{_messageEnd}");
    }

    public void DisplayCountdown()
    {
        for (int i = 0; i < Math.Round(_time / 6); i++)
        {
            CountdownAnimation();
        }
    }

    public void CountdownAnimation()
    {
        for (int j = 6; j > 1; j--)
        {
            Console.Write(j);
            Console.Write("\b");
            Thread.Sleep(1000);
        }
    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, string messageStart, string messageEnd) : base(activityName, description, messageStart, messageEnd)
    {
        
    }

    public void DisplayBreathing()
    {
        
    }
}

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string activityName, string description, string messageStart, string messageEnd, List<string> prompts, List<string> questions) : base(activityName, description, messageStart, messageEnd)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public string DisplayPrompts()
    {
        Random rand = new Random();
        int next = rand.Next(0, _prompts.Count);
        return _prompts[next];
    }

    public string DisplayQuestions()
    {
        Random rand = new Random();
        int next = rand.Next(0, _questions.Count);
        return _questions[next];
    }
}

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string activityName, string description, string messageStart, string messageEnd, List<string> prompts) : base(activityName, description, messageStart, messageEnd)
    {
        _prompts = prompts;
    }

    public string DisplayPrompts()
    {
        Random rand = new Random();
        int next = rand.Next(0, _prompts.Count);
        return _prompts[next];
    }
}