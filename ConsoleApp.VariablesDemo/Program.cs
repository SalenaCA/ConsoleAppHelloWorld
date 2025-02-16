// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "Salena";
Console.WriteLine("my name is " + name);

int age = 67;
int retirementAge = 80;
Console.WriteLine(age);
Console.WriteLine(retirementAge);
Console.WriteLine(age+retirementAge);

bool isRetired=false;
Console.WriteLine("is he retired?" + isRetired);

// declare vaiables
string Fname= string.Empty; // give variable default value 
int User_age = 0;

Console.WriteLine("Enter your name: ");
name = Console.ReadLine(); // receive imput from user

Console.WriteLine("Enter your age: ");
User_age = Convert.ToInt32(Console.ReadLine()); // input entered is a string have to convert it 

int workingAge = retirementAge - User_age;

Console.WriteLine("Full name:" + name);
Console.WriteLine("Age:" + User_age);
Console.WriteLine("Working years remaining:" + workingAge);







