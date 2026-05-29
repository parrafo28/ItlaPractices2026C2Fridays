
//using My1Program;

//Console.WriteLine("Hello World");


//Console.ReadKey();

////c# is case sensitvie

////Console.WriteLine("Hello World");
////Console.Writeline("Hello World");

////var number = 10;
////var Number = 20;
////var NUMBER = 30;
////var nUmBeR = 40;

////c# is multilanguage
////var año = 2024;
////var 你好 = "Hello";

////var year = 2024;

////comments in c#

////single line comment
//// This is a single line comment

//   This is a
//   multi-line comment
//   in C# */

////var myClass = new MyFirstClass();
////myClass.MyProperty = 42;


////variables in c#

////variables types by inference
//var myIntNumber = 10;
//var myDoubleNumber = 3.14;
//var myString = "Hello, C#!";
//var myBoolean = true;
////var myBoolean3 ;
//myBoolean = false;

////variables with explicit primitives types
//int myIntNumber2 = 20;
//short myShortNumber = 30000;
//float myFloatNumber = 3.14f;
//decimal myDecimalNumber = 3.14m;
//string myString2 = "Hello, C#!";
//bool myBoolean2 = false;

short iAcceptOnlyShortValues = 30000; //16 bits 5 digits
int iAcceptOnlyIntValues = 999999999; //32 bits 10 digits
long iAcceptOnlyIntValues2 = 999999999999999999; //64 bits 19 digits
decimal IAcceptDecimalValuesButICanAcceptIntsFloatsAndDoubles = 123456789.1234567890123456789m; //128 bits  28-29 digits
double IAcceptDoubles = 123456789.123456789; //64 bits 15-16 digits;
float IAcceptFloats = 123.4567f; //32 bit 7 digits
bool iOnlyAcceptTrueOrFalse; //if is false i dont have to expecify it
string IAcceptStringValues = "";
string IAcceptStringValues2 = string.Empty;
string IAcceptStringValues3 ;
char iAcceptCharactherValues = 'q';

//int myIntNumber3; //declaration
////myIntNumber3 = new int(); //instantiation
//myIntNumber3 = 30; //initialization
//myIntNumber3 = 350; //asignation

////naming conventions in c#

////camelCase for variables and methods
//var myVariableName = "This is a variable name in camelCase";
////var 1pyVariableName = "This will cause a compile-time error because variable names cannot start with a number";
//var myVariableName2 = "This is another variable name in camelCase";


//////privates variables and fields in camelCase with an underscore prefix
////private int _myPrivateVariableName = 42;


////pascalCase for classes, methods and properties
////public class MyClassName
////{
////    public string MyPropertyName { get; set; }
////    public void MyMethodName()
////    {
////        Console.WriteLine("This is a method name in PascalCase");
////    }
////}
////snake_case for constants
//const int MY_CONSTANT_VALUE = 100;

////MY_CONSTANT_VALUE = 200; // This will cause a compile-time error because constants cannot be reassigned


//var myFakeNumber = "10";
//var myRealNumber = 10;

//////arithmetic operators in c#
//var concatenation = myFakeNumber + 5; //concatenation

//var sum = myRealNumber + 5; // addition

//Console.WriteLine(concatenation); // Output: "105"
//Console.WriteLine(sum);
////var difference = myRealNumber - 3; // subtraction

////var product = myRealNumber * 2; // multiplication
////var quotient = myRealNumber / 2; // division
////var remainder = myRealNumber % 3; // modulus

////var exponentiation = myRealNumber ^ 2; // exponentiation
////var sqareRoot = Math.Sqrt(myRealNumber); // square root

//var num1 = 10;
//var num2 = 2;
//var num3 = 2;
//var num4 = 2;
//var num5 = 2;

//var result7 = num1 + num2 * num3 * num4 ^ num5 + num2 - num5 * num4 % num5;
//////result7 = num1 + num2 * num3 *   numtemp1  + num2 - num5 * num4 % num5; 
//////result7 = num1 +   numtemp2  *   numtemp1  + num2 - num5 * num4 % num5;
//////result7 = num1 +   numtemp2  *   numtemp1  + num2 - num5 *  numtemp3;
//////result7 = num1 +          numtemp4         + num2 - num5 *  numtemp3;
//////result7 = num1 +          numtemp4         + num2 -    numtemp5;
//////result7 =      numtemp6                    + num2 -    numtemp5;
//////result7 =                      numtemp7     -          numtemp5;
//////result7 =                                  numtemp8;

//var result8 = ((num1 + ((num2 * num3) * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
//var result9 = ((num1 + (num2 * num3 * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
//var result10 = (num1 + (num2 * num3) * (num4 ^ num5) + (num2 - num5) * (num4 % num5));
//var result11 = (num1 + num2) * num3 * (num4 ^ num5) + (num2 - num5 * (num4 % num5));


//Console.WriteLine($"{result7}   {result8}   {result9}    {result10}     {result11}");

//display messages in c#
//WriteLine is a method that belongs to the Console class in the System namespace. It is used to display messages or output to the console. You can use it to print text, variables, or any other information you want to show to the user.
//Console.WriteLine("First Line");  
//Console.WriteLine("Second Line");

////Write is another method that belongs to the Console class. It is similar to WriteLine, but it does not add a new line after the output. This means that if you use Write, the next output will be printed on the same line.
//Console.Write("First Part of the Line, ");
//Console.Write("Second Part of the Line.");
//Console.Write(" This will be on the same line.");

//Console.Write("First Part of the Line, Second Part of the Line. This will be on the same line.");

//special characters in strings
//backslash (\n) is used to represent a new line character in a string. When you include \n in a string, it tells the console to move to the next line when displaying the output. This allows you to create multi-line messages or format your output in a more readable way. 
//Console.WriteLine("This is a line with a\n new line character.\nThis will be \non a new line.");
////backslash (\t) is used to represent a tab character in a string. When you include \t in a string, it tells the console to insert a horizontal tab space at that point in the output. This can be useful for aligning text or creating columns of data in your console output.
//Console.WriteLine("This is a line with a tab character.\tThis will be after a tab space.");

//Console.WriteLine(@"This is a line with a \n
// new line character.
//This will be 
//on a new line.");

//string concatenation in c#

//using System.Text;

/////* what ever you write here will be ignored by the compiler
//var name = "Alice";
//var lastName = "Smith";

////single string concatenation
//var message = "Hello, " + name + " " + lastName + "! Welcome to C# programming.";

////using string builder for apend multiple strings together 
//StringBuilder message2 = new StringBuilder();
//message2.Append("Hello, ");
//message2.Append(name);
//message2.Append(" ");
//message2.Append(lastName); 
//message2.Append("! Welcome to C# programming.");

////string format
//var message3 = string.Format("Hello, {0} {1}! Welcome to C# programming.", name, lastName);
//var message4 = string.Format("Hello, {1} {0}! Welcome to C# programming.", lastName, name);

////string interpolation
//var message5 = $"Hello, {name} {lastName}! Welcome to C# programming.";


//Console.WriteLine(message);
//Console.WriteLine(message2);
//Console.WriteLine(message3);
//Console.WriteLine(message4);
//Console.WriteLine(message5);

//capture information from the user in c#

//Console.WriteLine("Please enter some information:");

////ReadLine is a method that belongs to the Console class in the System namespace. It is used to read input from the user through the console. When you call Console.ReadLine(), the program will pause and wait for the user to type something and press Enter. The input entered by the user will be returned as a string, which you can then store in a variable or use in your program as needed.
//var userInput = Console.ReadLine();
//Console.WriteLine(userInput);

//Read is another method that belongs to the Console class. It is used to read a single character from the user input. When you call Console.Read(), the program will pause and wait for the user to type a character and press Enter. The input entered by the user will be returned as an integer representing the ASCII value of the character. You can convert this integer back to a character using a cast or by using the Convert.ToChar() method.
//var userInput = Console.Read();
//Console.WriteLine(userInput);

//convertion of types in c#
Console.WriteLine("Please enter a number:");

var userInput = Console.ReadLine();
var convertedNumber = Convert.ToInt32(userInput);
var convertedNumer2 = int.Parse(userInput);

int.TryParse(userInput, out int convertedNumer3);


Console.ReadKey();

