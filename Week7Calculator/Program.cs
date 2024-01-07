
Console.WriteLine("Enter the operator (+/-)");
char userOperator = char.Parse(Console.ReadLine());


Console.WriteLine("Enter number a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter number b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum); 
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

switch (userOperator)
{
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

 static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}