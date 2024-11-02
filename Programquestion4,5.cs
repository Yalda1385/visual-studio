double userInput;

while (true)
{
    Console.WriteLine("Please enter a number(or type'exit' to quit):");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        break;
    }

    if (double.TryParse(input, out userInput))
    {
        Console.WriteLine($"You entered: {userInput}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}




Console.WriteLine("Enter a single characters (letters, numbers , symbols).Type 'exit' to quit");

while (true)
{
    string input = Console.ReadLine();

    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    if (input.Length == 1)
    {
        Char character = input[0];
        Console.WriteLine($"You entered:{character}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a single letters, numbers, or symbols.");
    }
}
  Console.WriteLine("Program exited");

static bool IsValidInput(string input)
{
    foreach (char c in input)
    {
        if (!char.IsLetterOrDigit(c) && !char.IsPunctuation(c))
        {
            return false;
        }
    }
    return true;
}





