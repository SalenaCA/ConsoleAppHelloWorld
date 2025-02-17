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
Console.WriteLine();

// declare vaiables
string? Fname= string.Empty; // string? allows the variable to be null, store nothing 
string Lname = string.Empty;
int User_age = 0;
decimal salary = 0;
char gender = char.MinValue;
bool working= false;

// prompt user for input
Console.Write("Enter your first name: ");
Fname = Console.ReadLine(); // receive imput from user
Console.Write("Enter your last name: ");
Lname = Console.ReadLine();


Console.Write("Enter your age: ");
User_age = Convert.ToInt32(Console.ReadLine()); // input entered is a string have to convert it 

Console.Write("Enter salary: ");
salary= Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter gender: (M of F) " );
gender=Convert.ToChar(Console.ReadLine());
Console.Write("Are you working? Trur or False ");
working= Convert .ToBoolean(Console.ReadLine());

//process the data
int workingAge = retirementAge - User_age;

// output the information 
Console.WriteLine("Full name:" + Fname + " " + Lname);
Console.WriteLine("Age:" + User_age);
Console.WriteLine("Working years remaining:  " + workingAge);
Console.WriteLine("Salary " + salary);
Console.WriteLine("Gender " + gender);
Console.WriteLine("Working " + working);

//refactor means change code 





