// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("please enter a grade: ");
// global variable
int grade=Convert.ToInt32(Console.ReadLine());

if (grade > 50)
{
    Console.WriteLine("you pass");
}
else
{
    Console.WriteLine("you fail");
}
Console.WriteLine("Thank you");

// if then else if
if (grade <0 || grade > 100)
{
    Console.WriteLine("Invalid grade!");
}
else if (grade <50)
{
    Console.WriteLine("Students failed: D");
}
else if (grade >50 && grade<= 70)
{
    Console.WriteLine("you have passed: C");
}
else if (grade >70 &&  grade <=80)
{
    Console.WriteLine("Good Job!: B");
}
else
{
    Console.WriteLine("Well Done: A+");
}
string status = grade < 50 ? "fail" : "pass";
Console.WriteLine(status);

// Using a switch
Console.Write("Please enter day of week: ");
int dayOfWeek=Convert.ToInt32(Console.ReadLine());
switch(dayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2: 
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;

    default:
        Console.WriteLine("Invalid day");
        break;
}
