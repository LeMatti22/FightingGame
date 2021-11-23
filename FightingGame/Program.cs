using System;

Console.Title = "colloseum";

//variables
int HP1 = 20;
int HP2 = 20;

string name = null;

Random generator = new Random();

//Game Start
 Console.WriteLine("[Press Any Key To Start The Game.]");
 Console.ReadKey();
 Console.Clear();

Console.WriteLine("Welcome warrior, state your name!");
Console.WriteLine("[Write your name below and please make it between 4 and 10 characters long]");
name = Console.ReadLine();


while (name.Length < 4 || name.Length > 10) //checks how long the name is and makes sure it's between 4 and 10 characters long.
{
if (name.Length > 10)
{
    Console.WriteLine("That name is too long, please shorten it!");
    name = Console.ReadLine();
}
else if (name.Length < 4)
{
    Console.WriteLine("That name is too short, please make it longer!");
    name = Console.ReadLine();
}
}


Console.WriteLine("[Press any key to start the battle]");
Console.ReadKey();
Console.Clear();

while(HP1 > 0 && HP2 > 0)
{
    Console.WriteLine("----[New Round]----");
    Console.WriteLine($"{name} VS Generic Gladiatior");
    Console.WriteLine();
    Console.WriteLine($"Your HP: {HP1}");
    Console.WriteLine($"Generic Gladiators HP: {HP2}");
    Console.WriteLine();

    int damage1 = generator.Next(20);
    HP2 -= damage1;
    HP2 = Math.Max(0, HP2);

    int damage2 = generator.Next(10);
    HP1 -= damage2;
    HP1 = Math.Max(0, HP1);

    Console.WriteLine($"In this round you dealt {damage1} damage to the Generic Gladiator");
    Console.WriteLine($"In return he dealt {damage2} damage to the you");

    Console.WriteLine("[Press any key to go to the next round]");

    Console.ReadKey();
    Console.Clear();
}

if(HP2 == 0)
{
    Console.WriteLine("You Won!");
}
else if (HP1 == 0)
{
    Console.WriteLine("You Lost!");
}


Console.ReadKey();