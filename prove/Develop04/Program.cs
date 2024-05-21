using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        BreathingActivity breathing = new BreathingActivity(
            "Breathing", 
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
            "",
            ""
        );

        List<string> promptList = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done something like this before?",
            "How did you get started?",
            "How did you feel when the experience was over?",
            "What made this experience different from other ones?"
        };

        ReflectionActivity reflection = new ReflectionActivity(
            "Reflection", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            "",
            "",
            promptList,
            questions
        );

        List<string> promptList2 = new List<string>
        {
            "Who are the people in your life that you appreciate?",
            "What are some personal strengths you have?",
            "Who have you helped during the week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        ListingActivity listing = new ListingActivity(
            "Listing",
            "This activity will help you think about the good things in your life by having you list as many things as you can in a certain area.",
            "",
            "",
            promptList2
        );

        Console.WriteLine("Welcome to Mindfulness");
        while (!quit)
        {
            switch (Menu())
                {
                    case "1":
                        breathing.ActivityStart();
                        breathing.DisplayBreathing();
                        break;
                    case "2":
                        reflection.ActivityStart();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"\n{reflection.DisplayPrompts()}\n");
                        Console.WriteLine($"{reflection.DisplayQuestions()}\n");
                        break;
                    case "3":
                        listing.ActivityStart();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"\n{listing.DisplayPrompts()}\n");
                        break;
                    case "4":
                        quit = true;
                        break;
                    default:
                        break;
                }
        }
    }

    static string Menu()
    {
        string input;
        Console.WriteLine("Select an option from the menu below to get started: ");
        Console.WriteLine("    1. Breathing Activity");
        Console.WriteLine("    2. Reflection Activity");
        Console.WriteLine("    3. Listing Activity");
        Console.WriteLine("    4. Quit");
        input = Console.ReadLine();
        return input;
    }
}