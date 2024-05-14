using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Sam = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(Sam.GetSummary());
        MathAssignment Rob = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(Rob.GetSummary());
        Console.WriteLine(Rob.GetHomeworkList());
        WritingAssignment Mary = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(Mary.GetSummary());
        Console.WriteLine(Mary.GetWritingInformation());
    }
}