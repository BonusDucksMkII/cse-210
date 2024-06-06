class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(new DateTime(2024, 06, 4), 30, 4);
        Cycling cycle = new Cycling(new DateTime(2024, 04, 17), 60, 30);
        Swimming swim = new Swimming(new DateTime(2024, 05, 20), 20, 20);
        List<Activity> ActivityList = new List<Activity>();
        ActivityList.Add(run);
        ActivityList.Add(cycle);
        ActivityList.Add(swim);

        foreach (Activity act in ActivityList)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}