
public class Entry{
    public string _date;
    public string _prompt;
    public string _body;
}

class Program
{
    static void Main()
    {  
        Journal journal = new Journal{
            _entries = new List<Entry>()
        };
        Prompt promptList = new Prompt{
            _prompts = new List<string>{
            "What out-of-the-ordinary thing happened today (big or small)?",
            "What food did you eat for lunch?",
            "What small act of kindness did you do for someone, or did someone do one for you?"
            }
        };
        int userOption;
        bool quit = false;
        string line;
        string lineSeparate = "-------------------------------------------";

        Console.WriteLine("Welcome to your journal.");
        while (!quit){
            Console.WriteLine("Enter the number of your choice: ");
            Console.WriteLine("    1. Write a new entry");
            Console.WriteLine("    2. Read journal");
            Console.WriteLine("    3. Save your journal");
            Console.WriteLine("    4. Load your journal");
            // Console.WriteLine("    5. Help");
            Console.WriteLine("    0. Exit");
            userOption = int.Parse(Console.ReadLine());
            if (userOption == 1)
            {

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString(),
                    _prompt = promptList.getPrompt()
                };

                Console.WriteLine(newEntry._date);
                newEntry._body += $"{newEntry._date}\n";
                Console.WriteLine(newEntry._prompt);
                newEntry._body += $"{newEntry._prompt}\n";
                Console.WriteLine(lineSeparate);
                newEntry._body += $"{lineSeparate}\n";
                newEntry._body += Console.ReadLine();
                newEntry._body += $"\n{lineSeparate}\n";

                journal._entries.Add(newEntry);
            } 
            else if (userOption == 2)
            {
                try
                {
                    foreach(Entry entry in journal._entries){
                        Console.WriteLine(entry._body);
                    }
                }
                catch (Exception e){
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Your journal has no entries yet!");
                }
            } 
            else if (userOption == 3)
            {
                Console.WriteLine("Enter the name of your journal: ");
                string journalFile = $"{Console.ReadLine()}.txt";
                using (StreamWriter outputFile = new StreamWriter(journalFile)){
                    try
                    {
                        foreach (Entry entry in journal._entries){
                            outputFile.WriteLine($"{entry._body}");
                        }
                    }
                    catch (Exception e){
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Your journal has no entries yet!");
                    }
                }
            }
            else if (userOption == 4)
            {
                Console.WriteLine("Enter the name of the file: ");
                string journalFile = $"{Console.ReadLine()}.txt";
                try 
                {
                    using (StreamReader inputFile = new StreamReader(journalFile)){
                    line = inputFile.ReadLine();
                        while (line != null){
                            Console.WriteLine(line);
                            line = inputFile.ReadLine();
                        }
                    }
                }
                catch (Exception e){
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Your journal has no entries yet!");
                }
            }
            else if (userOption != 0)
            {
                Console.WriteLine("Invalid option. Please try again.");
            } 
            else 
            {
                quit = true;
            }
        }
        Console.WriteLine("Bye.");
    }
}