Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secundNum = Int32.Parse(Console.ReadLine());

switch(userOperator)
{
    case '+':
        Addition(firstNum, secundNum);
        break;
    case '-':
        Subtraction(firstNum, secundNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}
static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction (int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}