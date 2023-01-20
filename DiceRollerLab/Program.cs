using System;
using System.Xml.Serialization;


Console.WriteLine("Welcome to Casino! ");
bool runProgram = true;

Console.WriteLine("How many sides should each die have? ");

int sides = 0;
var roles = 1;

while (int.TryParse(Console.ReadLine(), out sides) == false)
{
    Console.WriteLine("Not a number. Try again");
}

while (true)

{
    Console.WriteLine($"Roll {roles++}");
    
    int die1 = GetRandom(sides);
    int die2 = GetRandom(sides);
    Console.WriteLine($"You rolled a {die1} and a {die2} for a total of {die1 + die2}");

    Console.WriteLine("Roll again? (y/n): ");
    string again = Console.ReadLine().Trim().ToLower();

    if (again == "y")
    {
        runProgram = true;
        
    }
    else
    {
        runProgram &= false;
        Console.WriteLine("Thanks for playing!");
        break;  
    }
}

static int GetRandom(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}

static int GetRandom2(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}
static bool IsSixSided(int sides)
{
    if(sides == 6)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int dice1 = 0;
int dice2 = 0;
//static string CheckDice(int dice1, int dice2);
{ 
    while (sides == 6)
    if (dice1 + dice2 == 2)
    {
        Console.WriteLine("snake eyes");
    }
    if (dice1 + dice2 == 3)
    {
        Console.WriteLine("ace deuce");
    }
    if (dice1 + dice2 == 12)
    {
        Console.WriteLine("box cars, craps");
    }
    if (dice1 + dice2 == 7)
    {
        Console.WriteLine("win");
    }
    if (dice1 + dice2 == 11)
    {
        Console.WriteLine("win");
    }
    if (dice1 + dice2 == 2)
    {
        Console.WriteLine("craps");
    }
    if (dice1 + dice2 == 3)
    {
        Console.WriteLine("craps");
    }
    if (dice1 + dice2 ==4)
    {
        Console.WriteLine();
    }
    if (dice1 + dice2 == 5)
    {
        Console.WriteLine();
    }
    if (dice1 + dice2 == 6)
    {
        Console.WriteLine();
    }
    if (dice1 + dice2 == 8)
    {
        Console.WriteLine();
    }
    if (dice1 + dice2 == 9)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();        
    }
}
    
    

