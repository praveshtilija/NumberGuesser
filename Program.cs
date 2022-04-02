// Get app info function
GetAppInfo();

// Greet user function
GreetUser();

while (true)
{
    // Random correct number from 1-10
    Random random = new Random();
    int rightNumber = random.Next(1, 11);
    // Initial guess variable
    int guess = 0;

    Console.WriteLine("Guess a number between 1 and 10");

    while (guess != rightNumber)
    {
        string input = Console.ReadLine();
        // Must be int
        if (!int.TryParse(input, out guess))
        {
            PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
            continue;
        }
        guess = Int32.Parse(input);
        if (guess != rightNumber)
        {
            PrintColorMessage(ConsoleColor.Red, "Wrong Number! Please try again.");
        }
    }
    // Success message
    PrintColorMessage(ConsoleColor.Yellow, "You are correct!!");

    // Ask to play again
    Console.WriteLine("Play Again? [Y or N]");
    string answer = Console.ReadLine().ToUpper();
    if(answer == "Y")
    {
        continue;
    }
    else if(answer == "N")
    {
        return;
    }
    else
    {
        return;
    }
}

static void GetAppInfo()
{
    string appName = "Number Guesser";
    string appVersion = "1.0.0";
    string appAuthor = "Pravesh Tilija";

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
    Console.ResetColor();
}

static void GreetUser()
{
    Console.WriteLine("What is your name?");
    string userInput = Console.ReadLine();
    Console.WriteLine("Hello {0}, let's play a game...", userInput);
}

static void PrintColorMessage(ConsoleColor color, string message)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
}