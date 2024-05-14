
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = string.Empty;
        
        string newText = "Behold, my soul delighteth in proving unto my people the truth of the coming of Christ; for, for this end hath the law of Moses been given; and all things which have been given of God from the beginning of the world, unto man, are the typifying of him.";

        Reference refer = new("2 Nephi", 11, [4]);

        Scripture newScripture = new(refer, newText);

        Console.WriteLine("Welcome to the scripture memorizer!");
        Console.WriteLine("Press enter to start memorizing; type quit to stop the program.");
        Console.WriteLine("\n");

        while (input != "quit")
        {
            if (newScripture.Reference.Verses.Count > 1)
            {
                Console.WriteLine($"{newScripture.Reference.Book} {newScripture.Reference.Chapter}:{newScripture.Reference.Verses.First()-newScripture.Reference.Verses.Last()}");
            }
            else
            {
                Console.WriteLine($"{newScripture.Reference.Book} {newScripture.Reference.Chapter}:{newScripture.Reference.Verses.First()}");
            }
            
            foreach (Word word in newScripture.Text)
            {
                Console.Write($"{word.GetText()} ");
            }

            input = Console.ReadLine();
            if (input == "quit")
            {
                Console.WriteLine("See ya!");
                break;
            }
            hideWords(newScripture);
            Console.WriteLine();
        }
    }

    static void hideWords(Scripture inputScripture)
    {
        Random randWord = new Random();
        int nextWord;
        int i = 0;

        while (i < 3)
        {
            nextWord = randWord.Next(inputScripture.Text.Count - i);
            if (inputScripture.Text[nextWord].HideWord == false)
                {
                    Regex pattern = new Regex("[A-Z]|[a-z]");
                    inputScripture.Text[nextWord].Hide();
                    inputScripture.Text[nextWord].SetText(pattern.Replace(inputScripture.Text[nextWord].Text, "-"));
                    i++;
                }
        }
    }
}