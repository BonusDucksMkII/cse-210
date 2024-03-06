using System;

class Program
{
    static void Main(string[] args)
    {
        Job _job1 = new Job();
        _job1._jobTitle = "Software Engineer";
        _job1._company = "Microsoft";
        _job1._startYear = 2008;
        _job1._endYear = 2023;

        Job _job2 = new Job();
        _job2._jobTitle = "Database Engineer";
        _job2._company = "Oracle";
        _job2._startYear = 2023;
        _job2._endYear = 2024;

        Console.WriteLine(_job1.displayJob());
        Console.WriteLine($"{_job2.displayJob()}\n");


        // Simplified initialization
        Resume _myResume = new Resume
        {
            _fullName = "Jonathan Todd"
        };

        _myResume._jobs.Add(_job1);
        _myResume._jobs.Add(_job2);

        _myResume.displayResume();
    }
}