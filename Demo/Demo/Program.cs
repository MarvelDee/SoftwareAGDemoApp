Console.WriteLine("Enter a number:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter an operator (+, -, *, /):");
string op = Console.ReadLine();

Console.WriteLine("Enter another number:");
int number2 = int.Parse(Console.ReadLine());

int result;

if (op == "+")
{
    result = number1 + number2;
}
else if (op == "-")
{
    result = number1 - number1;
}
else if (op == "*")
{
    result = number1 * number2;
}
else if (op == "/")
{
    result = number1 / number2;
}
else
{
    Console.WriteLine("Invalid operator.");
    return;
}
Console.WriteLine("The result is: " + result);
Console.ReadKey();
