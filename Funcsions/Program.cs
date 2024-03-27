Console.WriteLine("Are you coming or leaving? (in/ouy):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

 static void PrintHello() // fuctsion ehk meetod
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later!");
}