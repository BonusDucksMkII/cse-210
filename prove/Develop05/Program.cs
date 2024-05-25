class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        int input;

        int totalScore = 0;
        List<Goal> GoalList = new List<Goal>();
        GoalManager goalGuy = new GoalManager(GoalList, totalScore);

        while (!quit)
        {
            Console.WriteLine("Welcome to the Goal Tracker!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("     1. Create a new goal");
            Console.WriteLine("     2. Display your goals");
            Console.WriteLine("     3. Save your goals");
            Console.WriteLine("     4. Load your goals");
            Console.WriteLine("     5. Mark a goal as complete");
            Console.WriteLine("     6. Check your stats");
            Console.WriteLine("     7. Quit");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("What kind of goal would you like to create?");
                Console.WriteLine("     1. Simple Goal");
                Console.WriteLine("     2. Checklist Goal");
                Console.WriteLine("     3. Eternal Goal");
                Console.WriteLine("     4. Go back");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("A simple goal is typically something short-term and a one-time thing.");

                    Console.Write("Enter in the name you want your goal to have: ");
                    string newName = Console.ReadLine();
                    Console.Write("Describe your goal; what do you want to accomplish? ");
                    string newDesc = Console.ReadLine();
                    Console.Write("How many points do you think this goal is worth for completing it? ");
                    int newPoints = int.Parse(Console.ReadLine());
                    SimpleGoal newSimple = new SimpleGoal(newName, newDesc, newPoints);
                    goalGuy.CreateGoal(newSimple);
                }
                else if (input == 2)
                {
                    Console.WriteLine("A checklist goal is something you're going to complete multiple times before being done.\nYou'll get bonus points for completing it all the way!");

                    Console.Write("Enter in the name you want your goal to have: ");
                    string newName = Console.ReadLine();
                    Console.Write("Describe your goal; what do you want to accomplish? ");
                    string newDesc = Console.ReadLine();
                    Console.Write("How many points do you think this goal is worth for each time you complete it? ");
                    int newPoints = int.Parse(Console.ReadLine());
                    Console.Write("How many times are you going to complete this before you've accomplished the goal? ");
                    int newTimeToComplete = int.Parse(Console.ReadLine());
                    ChecklistGoal newChecklist = new ChecklistGoal(newName, newDesc, newPoints, newTimeToComplete, newPoints * 10);
                    goalGuy.CreateGoal(newChecklist);
                }
                else if (input == 3)
                {
                    Console.WriteLine("An eternal goal is something you're going to have to do continually, in order to\nreach something that may not be finished for a long time or even during our lifetimes.");

                    Console.Write("Enter in the name you want your goal to have: ");
                    string newName = Console.ReadLine();
                    Console.Write("Describe your goal; what do you want to accomplish? ");
                    string newDesc = Console.ReadLine();
                    Console.Write("How many points do you think this goal is worth for each time you complete it? ");
                    int newPoints = int.Parse(Console.ReadLine());
                    EternalGoal newEternal = new EternalGoal(newName, newDesc, newPoints);
                    goalGuy.CreateGoal(newEternal);
                }
            }
            else if (input == 2)
            {
                goalGuy.DisplayGoals();
            }
            else if (input == 3)
            {
                Console.Write("Please enter in the file name: ");
                string fileName = Console.ReadLine();
                goalGuy.SaveGoals(fileName);
            }
            else if (input == 4)
            {
                Console.Write("Please enter in the file name: ");
                string fileName = Console.ReadLine();
                goalGuy.LoadGoals(fileName);
            }
            else if (input == 5)
            {
                List<Goal> temp = goalGuy.GetGoalList();
                if (temp.Count > 0)
                {
                    int i = 1;
                    foreach (Goal goal in temp)
                    {
                        if (!goal.GetComplete())
                        {
                            Console.WriteLine($"[{i}] {goal.GetName()} - {goal.GetDesc()}");
                            i++;
                        }
                    }
                    Console.WriteLine("Enter which goal to add an event to: ");
                    string choice = Console.ReadLine();
                    try
                    {
                        Goal t = temp[int.Parse(choice) - 1];
                        Console.Write("When did you complete your goal (please enter in a date in mm/dd/yy format)? ");
                        string newDate = Console.ReadLine();
                        Console.Write("What did you do (provide a short description)? ");
                        string newDesc = Console.ReadLine();
                        Event newEvent = new Event(newDate, newDesc);
                        goalGuy.RecordEvent(t, newEvent);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid choice. Try again.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Invalid choice. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("No goals to complete. Load your goals if you have any.");
                }
            }
            else if (input == 6)
            {
                goalGuy.DisplayInfo();
            }
            else if (input == 7)
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}