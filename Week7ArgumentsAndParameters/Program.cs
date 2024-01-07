Console.WriteLine("Enter something");
string UserInput = Console.ReadLine();

PrintAnyWord(UserInput); //userinput - argument


static void PrintAnyWord(string anyString) // anystring - parameter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i > 5; i++)
    {
        Console.WriteLine(anyString);
    }
}

