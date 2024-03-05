using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int userSum = 0;
        float userAvg = 0;
        int userLrgst = 0;
        int inputNum = 1;
        List<int> userNum;
        userNum = new List<int>();
        Console.WriteLine("Enter a list of numbers; enter 0 when finished.");
        while (inputNum != 0){
            Console.WriteLine("Enter number: ");
            inputNum = int.Parse(Console.ReadLine());
            userNum.Add(inputNum);
            if (inputNum > userLrgst){
                userLrgst = inputNum;
            }
            userSum += inputNum;
        }
        
        // Console.WriteLine(userNum.Count);
        userAvg = (float)userSum/(userNum.Count - 1);

        Console.WriteLine($"The sum of your numbers is: {userSum}\nThe average is: {userAvg}\nThe highest number is: {userLrgst}");
    }
}