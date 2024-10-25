// See https://aka.ms/new-console-template for more information
//Making a comment
/*
    Multi
    Line
    Comment
*/
//Write and it will go to next line of the console
Console.WriteLine("Hello, World!");

//types of variables
/*
    initializing a variable usually goes like:
    type variableName = value;
*/
int wholeNum = 8; //int stores whole numbers (no decimals)
double decimalNum = 6.4; //double stores floating point numbers (decimals)
char alphabetLetter = 'V'; //char stores single characters, needs to be surrounded by single quotes ('')
string longWord = "Multiple words can be stored"; //string stores text, surrounded by double quotes("")
bool isItTrue = false; //bool stores either true OR false

//A const does NOT allow others or yourself to overwrite existing values
const int constNum = 33; 

/*
    General rules for naming variables:
    Names can contain letters, digits and the underscore character (_)
    Names must begin with a letter or underscore
    Names should start with a lowercase letter, and cannot contain whitespace
    Names are case-sensitive ("myVar" and "myvar" are different variables)
    Reserved words (like C# keywords, such as int or double) cannot be used as names
*/

//Generic variable that can be most types
var num1 = 1;
var num2 = 4;

//Write but anything written after will be on one line/same line
//Console.Write can display variables and text, just use + inbetween
//This line will NOT add num1 and num2, it will concatenate them together
Console.WriteLine("Concatenate 2 declared variables: " + num1 + num2);

//If you need to use text and some form of math, use extra ()
Console.WriteLine("This will add numbers: " + (num2+decimalNum));


//Casting
/*
    Implicit casting can automatically be done when going from small --> larger (char -> int -> long -> float -> double)
    Explicit casting has to be done manually when going from large --> small (reverse of above)
*/
//Implicit example
double implicitExampleDouble = wholeNum;
Console.WriteLine("Original value of int var: " + wholeNum);
Console.WriteLine("Implicit var: " + implicitExampleDouble);

//Explicit example, the type needs to be done with parentheses
int explicitExampleInt = (int)decimalNum;
Console.WriteLine("Original value of double var: " + decimalNum);
Console.WriteLine("Explicit var: " + explicitExampleInt);

//Get user input for string(ReadLine returns a STRING)
Console.WriteLine("User enter a string: ");
string userString = Console.ReadLine(); //Read user input here
Console.WriteLine("User string is: " + userString);

/*Trying to understand parse converting
//Get user input for number(ReadLine returns a STRING)
    Console.WriteLine("User enter a number or else error: ");
    int userInt = Int32.TryParse.ReadLine(); //Read user input here
    Console.WriteLine("User number is: " + userInt);
*/

