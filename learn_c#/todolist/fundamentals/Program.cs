//###################
//Variables
//###################
//Console.WriteLine(name); //will not compile, because  is not yet declared and initialized


// an expression is a piece of code that evaluates to a value 

using System.Windows.Markup;

string name = "Nisha"; //variable initialization at declaration
int number; //variable declaration
number = 5; //variable initialization
number = 10; //assigning new value to a variable
Console.WriteLine(number); //10 will be printed
//int lastName = "Smith"; //will not compile, we can't assign string to int



//###################
//Naming variables
//###################
//string class = "First"; //will not compile, class is reserved keyword
string @class = "First"; //we can use a reserved keyword if we precede it with @
int _number = 10;
int also_some_number = 5; //valid name, but not in line with C# convention
int alsoSomeNumber = 5; //C# uses lower camel case
//int 1number = 1; //will not compile, digit cannot be the first character
string name1 = "Anna"; //digit is fine if it is not the first character
int age, Age; //they are two different variables, C# is case-sensitive 
              //int number-one = 10; //will not compile, we can't use '-'


//###################
//Operators
//###################
int sum = 5 + 10;
int resultNoParenthesis = 5 + 2 * 3;
int resultParenthesis = 5 + (2 * 3);
var stringAndInt = "abc" + 5;



//###################
//Implicitly typed variables
//###################
string word1 = "text"; //explicitly typed variable
var word2 = "text"; //implicitly typed variable
//var invalidVariable; //will not compile; implicitly typed variables must be initialized



//###################
//Comments
//###################

//this is a single-line comment
/*
this is
a multiline
comment
*/



//###################
//Boolean type.
//Logical negation, equality,
//comparison and modulo operators
//###################
Console.WriteLine("Enter a word:");
var userInput = Console.ReadLine();
bool isUserInputAbc = userInput == "ABC";
bool isUserInputNotAbc = userInput != "ABC";
bool isUserInputNotAbc2 = !(userInput == "ABC"); //will be the same as above
var isLargerThan5 = number > 5;
var isSmallerThan10 = number <= 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;
var is10Modulo3EqualTo1 = 10 % 3 == 1;
var isEven = number % 2 == 0;
var isOdd = number % 2 != 0;



//###################
//Boolean type.
//Logical negation, equality,
//comparison and modulo operators
//###################
var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6 = number == 2 || number > 6;
var isEqualTo2OrLargerThan6OrSmallerThan200 =
    number == 2 || number > 6 || number < 200;
var isEqualto123OrEvenAndSmallerThan20 =
    number == 123 || (number % 2 == 0 && number < 20);
var isLargerThan5OrSmallerThan0 = number > 5 || number < 5; //the second conditin will not be evaluated due to short-circuiting
var isSmallerThanZeroAndEven = number < 0 && number % 2 == 0; //the second conditin will not be evaluated due to short-circuiting



//###################
//if/else statements
//###################
if (userInput.Length <= 3)
{
    Console.WriteLine("Short answer");
}
else if (userInput.Length < 10)
{
    Console.WriteLine("Medium answer");
}
else
{
    Console.WriteLine("Long answer");
}



//###################
//Scopes
//###################
if (userInput.Length == 0)
{
    Console.WriteLine("Empty choice");
    var word7 = "ABC";
    int someNumber = 5;
    if (word7.Length > 0)
    {
        Console.WriteLine(someNumber); //someNumber is available here
    }
}
else
{
    int someNumber = 6; //named the same as the variable inside the "if". It is fine, because those variables live in different scopes
    Console.WriteLine("Your choice is: " + userInput);
    //Console.WriteLine(someNumber); //will not compile; someNumber is not available here
}
Console.WriteLine("Your choice is: " + userInput);



//###################
//Methods - part 1 - void methods
//###################
//See 1_TodoList project for more about methods
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}



//###################
//Methods - part 2 - non-void methods
//###################
//See 1_TodoList project for more about methods -- all paths in a nonvoid method must return a value 
int Add(int a, int b)
{
    return a + b;
}

bool IsLong(string input)
{
    return input.Length > 10;
}



//###################
//Parsing a string to an int
//###################
string numberAsText = "123";
int parsedToInt = int.Parse(numberAsText); //would not work if input was, for example, "abc"
// this is changing data types from an string to an int 



//###################
//String interpolation
//###################
int a = 4, b = 2, c = 10;
Console.WriteLine(
    "First is: " + a + ", second is: " + b + ", third is: " + c);

Console.WriteLine(
    $"First is: {a}, second is: {b}, third is: {c}");

Console.WriteLine(
    $"Sum is: {a + b + c}, second is: {b}, third is: {c}");



//###################
//String interpolation exercise 
//###################
string FormatDate(int year, int month, int day)
        {
            return $"{year}/{month}/{day}";
        }



//###################
//Switch statement
//###################
//See 1_TodoList project for more about switch
//###################
//Char
//###################
char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'E';
        default:
            return '!';
    }
}

//###################
//Switch statement -- exercise 
//###################
string DescribeDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Working day";
                    break;
                case 6:
                case 7:
                    return "Weekend";
                    break;
                default:
                    return "Invalid day number";
                    break;
            }
        }



// 'a' - a char representing the letter a 
// "a" - a string of length 1, consisting of one letter 


//###################
//While loop
//###################
var numberWhileLoop = 0; 
while (numberWhileLoop < 10)
{
    numberWhileLoop++;
    Console.WriteLine("Number is " + numberWhileLoop);
}

Console.WriteLine("the loop is finished");

var someText = "hello there";
while (someText.Length < 20) ;
{
    someText += 'a';
    Console.WriteLine(someText) ;
}
Console.WriteLine("the loop is finished");

// WHILE LOOP EXERCISE
int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
{
    int currentNumber = firstNumber;
    int sum = 0;
    while (currentNumber <= lastNumber)
    {
        sum += currentNumber;
        currentNumber++;
    }
    return sum;
}


//###################
//Do-while loop -- CODE IS EXECUTED BEFORE THE CONDITION IN THE WHILE LOOP so the code will be executed at least once 
//###################
string userInputLong;
do
{
    Console.WriteLine(
        "Enter input longer than 10 letters");
    userInputLong = Console.ReadLine();
} while (userInputLong.Length <= 10);

string word;
do
{
    Console.WriteLine("Enter a word longer than 10 letters");
    word = Console.ReadLine();
}
while (word.Length <= 10);
Console.WriteLine("the loop is finished");


//###################
//For loop
//###################
for (int i = 0; i < 10; i+=2)
{
    Console.WriteLine("Loop run " + i);
}
for  (int i = 10;  i >= 5; --i)
{
    Console.WriteLine("Loop run " + i);
}
Console.WriteLine("the loop is finished ");

int Factorial(int number)
{
    var result = 1; 
    for (int i = 1; i <= number; ++i)
    {
        result *= i;
    }
    return result;
}


//###################
//Break and continue
//###################
for (int i = 0; i < 100;  ++i)
{
    if (i > 25)
    {
        break;
    }
    Console.WriteLine("loop run " + i);
}

int userNumber; 
do
{
    Console.WriteLine(
        "Enter a number larger than 10: "
        );
    var input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }
    bool isParsableToInt = input.All(char.IsDigit);
    if (!isParsableToInt)
    {
        userNumber = 0;
        continue;
    }
    userNumber = int.Parse(input);
} while (userNumber < 10);

for (int i = 0; i < 20; i++)
{
    if (i % 3  == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}

//###################
//Nested loops
//###################

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            Console.WriteLine($"i is {i}, j is {j}");
        }
    }
}

// avoid nested loops, especially 3x nested loops 
// move performance-heavy code outside the loop or to outer loops 


//###################
//Arrays -- collections of fixed size of the same type, so once an array is created, its size cannot be changed 
// ex: Array (type: string[]) --> "abc"
// default value to an initialized array is 0 
// use the carrot symbol (^) to index from the end operator (replicating [array.Length - 1]
//###################
var numbers = new int[3];
Console.WriteLine("Element at index 0 is " + numbers[0]);
Console.WriteLine("Element at index 1 is " + numbers[1]);
Console.WriteLine("Element at index 2 is " + numbers[2]);

numbers[0] = 5; numbers[1] = 6; numbers[2] = 7;
Console.WriteLine("Element at index 0 is " + numbers[0]);
Console.WriteLine("Element at index 1 is " + numbers[1]);
Console.WriteLine("Element at index 2 is " + numbers[2]);

var numbers2 = new int[] {1, 2, 3, 4, 5,  6};
numbers2[2] = 10;
numbers2[3] = 11;
var firstFromEnd1 = numbers2[numbers2.Length - 1];
var firstFromEnd2 = numbers2[^1]; //this is the same as above 
var secondFromEnd1 = numbers2[numbers2.Length - 2];
var secondFromEnd2 = numbers2[^2];

int sumOfNumbers = 0;
for (int i = 0; i < numbers2.Length; i++)
{
    sumOfNumbers += numbers2[i];
}

string BuildHelloString()
{
    var letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
    var result = "";
    for (int i = 0; i < letters.Length; ++i)
    {
        result += letters[i];
    }
    return result;
}


//###################
//Multi-dimensional arrays
//###################

char[,] letters = new char[2, 3];
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';


var letters2 = new char[,]
{
    {'A', 'B','C' },
    {'D', 'E','F' },
};

var height = letters.GetLength(0);
var width = letters.GetLength(1);

for (var i =  0; i < height; i++)
{
    Console.WriteLine($"i is {i}");

    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"j is {j}");
        Console.WriteLine($"element is {letters[i,j]}");
    }
}


//###################
//Foreach loop
// there is no index for this 
//###################

var words = new string[] { "one", "two", "three" };
foreach (var word6 in words)
{
    Console.WriteLine(word6);
}

//###################
//Lists
// size is not fixed and can be modified after intialized and declared -- it is dynamic 
//###################
List<string> words2 = new List<string>();
Console.WriteLine("Count of elements is " + words2.Count);

var word3 = new List<string>
{
    "one",
    "two",
};
Console.WriteLine("count of the elements is " + word3.Count);
foreach (var word4 in word3)
{
    Console.WriteLine(word4);
}
word3.Add("three");
word3.Remove("one");
word3.Add("four");
word3.AddRange(new[] { "four", "five" });
word3.RemoveAt(0);
word3.RemoveAt(1);
var indexOfFive = word3.IndexOf("one"); // returns the index of the first occurrence specified 
bool containsOne = word3.Contains("one");
word3.Clear();


bool IsWordPresentInCollection(string[] words8, string wordToBeChecked)
{
    for (var i = 0; i < words8.Length; ++i)
    {
        if (words8[i] == wordToBeChecked)
        {
            return true;
        }
    }
    return false;
}

