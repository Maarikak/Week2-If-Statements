using System;

Console.WriteLine("Enter your first name");
string username = Console.ReadLine();
Console.WriteLine("Enter your last name");
string surname = Console.ReadLine();
Console.WriteLine("Enter your gender (f/m/n):");
char usergender = char.Parse(Console.ReadLine());

string greeting;

if (usergender == 'f')

{
    greeting = "Ms.";
}
else if (usergender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}
Console.WriteLine($"Hello, {greeting} {username} {surname} !");

Console.WriteLine("Enter Your year of birth:");

int usersYB = Int32.Parse(Console.ReadLine());
int currentyear = DateTime.Now.Year;
int userage = currentyear - usersYB;

//Console.WriteLine($"Current year: {currentyear} ");
//int userage = Int32.Parse(Console.ReadLine());


if (userage >= 13)
{
    Console.WriteLine($"You are {userage} - old enough to have an account");
}
else
{
    Console.WriteLine($"You are {userage} -  too young to have an account");
}
