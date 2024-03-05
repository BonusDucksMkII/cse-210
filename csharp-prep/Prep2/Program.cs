using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage? ");
        bool passed = false;
        string letter = "";
        int userGrade = int.Parse(Console.ReadLine());
        if (userGrade >= 90){
            passed = true;
            letter = "A";
        } else if (userGrade >= 80) {
            passed = true;
            letter = "B";
        } else if (userGrade >= 70) {
            passed = true;
            letter = "C";
        } else if (userGrade >= 60) {
            letter = "D";
        } else if (userGrade < 60) {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (passed == true){
            Console.WriteLine("Congrats! You passed!");
        } else {
            Console.WriteLine("You didn't make it. Sorry...");
        }
    }
}