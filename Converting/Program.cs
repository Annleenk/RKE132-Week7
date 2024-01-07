
//Console.WriteLine("Enter your unit of measurement(C/F)");
//char userOperator = char.Parse(Console.ReadLine());

//double newF = 0, newC = 0;
//switch (userOperator)
//{
//    case 'F':
//        Console.WriteLine("Enter the temperature(F)");
//        double newF
//        //int F = Int32.Parse(Console.ReadLine());
//        Console.WriteLine($"The temperature is {newF}C");
//        break;
//    case 'C':
//        Console.WriteLine("Enter the temperature (C)");
//        double newC
//        //int C = Int32.Parse(Console.ReadLine());
//        Console.WriteLine($"The temperature is {newC}F");
//        break;
//}

//static double newF(int F, int C) // F to C
//{
//    return (F-32)*5 / 9;
//}

//static double newC(int F, int C) //C to F
//{
//    return (C * 9 / 5) + 32;
//}

Console.WriteLine("Enter your unit of measurement (C/F)");
char userOperator = char.Parse(Console.ReadLine());

switch (userOperator)
{
    case 'F':
        ConvertToCelsius();
        break;

    case 'C':
        ConvertToFahrenheit();
        break;

    default:
        Console.WriteLine("Invalid input. Please enter 'C' or 'F'.");
        break;
}


    static void ConvertToCelsius()
{
    Console.WriteLine("Enter the temperature in Fahrenheit:");
    double tempF = double.Parse(Console.ReadLine());
    double tempC = (tempF - 32) * 5 / 9;
    Console.WriteLine($"The temperature is {tempC}°C");
}

static void ConvertToFahrenheit()
{
    Console.WriteLine("Enter the temperature in Celsius:");
    double tempC = double.Parse(Console.ReadLine());
    double tempF = (tempC * 9 / 5) + 32;
    Console.WriteLine($"The temperature is {tempF}°F");
}