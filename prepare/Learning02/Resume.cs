public class Resume{
    public string _fullName;
    public List<Job> _jobs = new List<Job>();

    public void displayResume(){
        Console.WriteLine($"Name: {_fullName}");
        Console.WriteLine("Jobs:\n");
        foreach (Job _job in _jobs){
            Console.WriteLine(_job.displayJob());
        }
    }
}