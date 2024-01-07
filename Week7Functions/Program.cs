
Console.WriteLine("Are you coming or going? (in/out)");
string userCHoice = Console.ReadLine();

if(userCHoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}

//PrintHello();
//PrintGoodbye();

static void PrintHello()//function, method "call on function"
{
    Console.WriteLine("Hello World");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later");
}
