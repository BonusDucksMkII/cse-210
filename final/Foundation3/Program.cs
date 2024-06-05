using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture event1 = new("A Big Hand to Pianists", "Examining the Role of Metacarpal Orthopediatry in Pianist Patients", new DateTime(2022, 04, 19), "7:30 PM", "4545 South Greynard Blvd", "Dr. Arthur Ulnar", 500);
        Reception event2 = new("Marriage of John Gauss and Emily Roberts", "Come celebrate Mr. and Mrs. Gauss' marriage!", new DateTime(2023, 06, 28), "5:00 PM", "238 West 995 West", "bigmausgauss@gmail.com");
        Gathering event3 = new("Biggums Family Reunion", "The Biggums Family is celebrating together", new DateTime(2024, 08, 12), "11:30 AM", "12020 S, Boy Howdy Park", "Sunny - 80 F");
        Console.WriteLine(event1.FullDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(event1.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(event1.ShortDesc());
        Console.WriteLine("=========================");
        Console.WriteLine(event2.FullDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(event2.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(event2.ShortDesc());
        Console.WriteLine("=========================");
        Console.WriteLine(event3.FullDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(event3.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(event3.ShortDesc());
        Console.WriteLine("=========================");
    }
}