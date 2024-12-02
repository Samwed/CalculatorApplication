// See https://aka.ms/new-console-template for more information
int num1 = 0;
int num2 = 0;
Console.WriteLine("Enter num1 Value");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num2 Value");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose the Calculation Mode");
Console.WriteLine("\t a - Addtion");
Console.WriteLine("\t b - Substraction");
Console.WriteLine("\t c - Multipication");
Console.WriteLine("\t d - Division");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine("num1 and num2 Addition is ->" + (num1 + num2));
        break;

    case "b":
        Console.WriteLine("num1 and num2 Substaction is ->" + (num1 - num2));
        break;

    case "c":
        Console.WriteLine("num1 and num2 Multipication is ->" + (num1 * num2));
        break;

    case "d":
        Console.WriteLine("num1 and num2 Division is ->" + (num1 / num2));
        break;

}
        