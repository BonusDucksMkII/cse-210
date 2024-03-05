using System;
using System.Runtime.InteropServices;

class Program
{
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        string userName;
        Console.WriteLine("What's your username? ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        int userNum;
        Console.WriteLine("What's your favorite number? ");
        userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquareNumber(int numSquared)
    {
        int newNum = (int)Math.Pow(numSquared, 2);
        return newNum;
    }

    static void DisplayResult(string userName, int userNum)
    {
        Console.WriteLine($"{userName}, the square of your favorite number is: {userNum}");
    }

    static void Main(string[] args)
    {
        displayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}