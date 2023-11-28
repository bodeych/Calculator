// See https://aka.ms/new-console-template for more information
double firstValue, secondValue;
string action;

Console.Write("First number: ");
firstValue = double.Parse(Console.ReadLine());

Console.Write("Second number: ");
secondValue = double.Parse(Console.ReadLine());

Console.Write("Select operation: '+', '-', '*', '/'");
action = Console.ReadLine();

switch (action)
{
    case "+":
        Console.WriteLine(firstValue + secondValue);
        break;
    case "-":
        Console.WriteLine(firstValue - secondValue);
        break;
    case "*":
        Console.WriteLine(firstValue * secondValue);
        break;
    case "/":
        if (secondValue == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(firstValue / secondValue);
        }
            break;

    default:
        Console.WriteLine("Error");
        break;
}
Console.ReadLine();
