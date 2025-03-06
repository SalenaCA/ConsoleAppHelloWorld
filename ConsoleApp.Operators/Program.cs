// See https://aka.ms/new-console-template for more information

Console.Write(" Please enter first number: ");
int num1=Convert.ToInt32(Console.ReadLine());

Console.Write(" Please enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//Arithmetic Operators

int sum= num1 + num2;
int minus= num1 - num2;
int product= num1 * num2;
int quotient = num1 / num2;
int mod= num1 % num2;

Console.WriteLine("******************* Maths Results*******************");
Console.WriteLine("Sum is: " + sum);
Console.WriteLine("Difference is: " + minus);
Console.WriteLine("Product is: " + product);
Console.WriteLine("Quotient is: " + quotient);
Console.WriteLine("Modulus is: " + mod);
Console.WriteLine("******************* EndMaths Results*******************");


/* > greater than
 * < less than
 * == equal
 * != not equal
 * && and
 * || or
 */

// Logic operations and operators use booleans

var isGreaterThan = num1 > num2; // var is a wild card data type 
bool isLessThan= num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1!=num2;

Console.WriteLine();
Console.WriteLine("******************* Logics Results*******************");

Console.WriteLine("Is greater than: " + isGreaterThan);
Console.WriteLine("Is less than: " + isLessThan);
Console.WriteLine("Is equal to: " + isEqualTo);
Console.WriteLine("IS greater than or equal to: " + isGreaterThanOrEqualTo);
Console.WriteLine("IS less than or equal to: " + isLessThanOrEqualTo);
Console.WriteLine("Is Not equal to: " + isNotEqualTo);
Console.WriteLine("******************* Logics Results*******************");

//Assignment operations and Operators

Console.WriteLine("******************* Assignment Results*******************");
Console.WriteLine();

num1 += 5;
Console.WriteLine("Add 5" + num1);

num1 -= 5;
Console.WriteLine("minus 5" + num1);

num1 /= 2;
Console.WriteLine("divided by 2" + num1);

num1 %= 2;
Console.WriteLine("modulous 2" + num1);

num1 *= 10;
Console.WriteLine("multiply by 10" + num1);



