using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction One = new Fraction(1);
        Fraction Five = new Fraction(5);
        Fraction ThreeOverFour = new Fraction(3, 4);
        Fraction OneOverThree = new Fraction(1, 3);

        Console.WriteLine(One.GetFractionString());
        Console.WriteLine($"{One.GetDecimalValue()}\n");

        Console.WriteLine(Five.GetFractionString());
        Console.WriteLine($"{Five.GetDecimalValue()}\n");

        Console.WriteLine(ThreeOverFour.GetFractionString());
        Console.WriteLine($"{ThreeOverFour.GetDecimalValue()}\n");

        Console.WriteLine(OneOverThree.GetFractionString());
        Console.WriteLine($"{OneOverThree.GetDecimalValue()}");
    }
}