﻿//###################
//Variables
//###################
//Console.WriteLine(name); //will not compile, because  is not yet declared and initialized


// an expression is a piece of code that evaluates to a value 

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
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
// for (initialization statement; condition to evaluate; updating action) 
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
/* break - forces the loop to terminate immediately without reevaluating the loops condition
 * . This lets us escape a loop we no longer want to keep running. The loops condition is not reevaluated so it means we can leave the loop
 * while its condition is still technically true
 * 
 * continue - will cause the loop to stop running the current pass through the loop but 
 * will advance to the next pass, recheck the condition, and keep looping if the condition holds. 
 * You can think of 'continue' as "skip the rest of this pass through the loop and continue to the next pass" 
 * 
 * 
 */

while (true) // this loops condition is true and would never finish without a break. But 
    // if the user types "quit" or "exit" the break statement is encounterer. 
    // if the user enters 12 then that continue statement is reached. Instead of displaying the 
    // text about the number being good, it tells the user to pick another one 
{
    Console.WriteLine("think of a number and type it here: ");
    string input = Console.ReadLine();

    if (input == "quit" || input == "exit")
        break;
    int number644 = Convert.ToInt32(input);
    if (number644 == 12)
    {
        Console.WriteLine("I don't like that number. Pick another one");
        continue; 
    }
    Console.WriteLine($"I like {number644}. It's the one before {number644 + 1}!");
} 

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
// - are common when you need to do something with every combination of two sets of things 
// ex: basic multiplication table, multiplying the numbers 1 through 10 against the same set of numbers 

for (int aa =1; aa <= 10;  aa++)
    for (int bb  = 1; bb <= 10; bb++)
        Console.WriteLine($"{aa} * {bb} = {aa*bb}");



// this code displays a grid of *'s based on the number of rows and columns dictated by totalRows and totalColumns
int totalRows = 5;
int totalCols = 10;

for (int currentRow = 1; currentRow <= totalRows; currentRow++)
{
    for (int currentCol = 1; currentCol <= totalCols; currentCol++)
        Console.Write("*");
    Console.WriteLine();
}


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




//###################
//CODING EXERCISE: 
//###################
int FindMax(int[,] numbers)
{
    int height = numbers.GetLength(0);
    if (height == 0)
    {
        return -1;
    }
    int width = numbers.GetLength(1);
    if (width == 0)
    {
        return -1;
    }

    int max = numbers[0, 0];

    for(var i =0; i < height; ++i)
    {
        for(var j =0; j < width; ++j)
        {
            var number = numbers[i, j];
            if (number>max)
            {
                max = number;

            }
        }
    }
    return max;
}



//###################
//CODING EXERCISE: 
//###################

List<string> GetOnlyUpperCaseWords(List<string> words)
{
    var result = new List<string>();
    foreach (var word in words)
    {
        if (result.Contains(word))
        {
            continue;
        }
        bool isWordUpperCase = true;
        foreach(char letter in word)
        {
            if(!char.IsUpper(letter))
            {
                isWordUpperCase = false;
            }
        }
        if(isWordUpperCase)
        {
            result.Add(word);
        }
    }
    return result;
}


//###################
//Out parameter -- option of how to return 2 values from one method 
// when we pass a variable as a parameter to a method, a copy of this variable is created 
//###################

var numbers3 = new[] { 10, -8, 2, 12, -17 };
int nonPositiveCount;
var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
foreach(var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();
    foreach(int number in numbers)
    {
        if (number>0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result; 
}

//###################
//Out parameter
// -- how to parse a string to an int without the risk of a runtime error 
// -- using the TryParse method 

/* the Parse method has an issue with it because it causes
 a runtime error if the type passed through is not correct so we will
 use the TryParse method instead */

//###################


bool isParsingSuccessful;

do
{
    Console.WriteLine("Enter a nubmer: ");
    var userInput1 = Console.ReadLine();
    isParsingSuccessful = int.TryParse(userInput1, out int number9);
    if (isParsingSuccessful)
    {
        Console.WriteLine("Parsing was successful " + number9);
    }
    else
    {
        {
            Console.WriteLine("Parsing was not successful");
        }
    }
} while (!isParsingSuccessful);



// TUPLES 
(string Name, int, int) score = ("r2-d2", 12333, 14);
void DisplayScore((string Name, int Points, int Level) score)
{
    Console.WriteLine($"Name: {score.Name} Level: {score.Level} Score: {score.Points}");
}
// parameters cannot use var so we are obligated to list the tuple item types in this case 

//(string Name, int Points, int Level) GetScore() => ("r2d2", 12340, 15); // you can return a tuple from a method by placing its consistuent parts in parentheses in the spot where we list the return type 

//var score2 = GetScore();
//Console.WriteLine($"Name: {score2.Name} Level: {score2.Level} Score: {score2.Points}");


(string One, int Twol, int Three) score3 = GetScore();
DisplayScore(score3);

(string N, int P, int L) GetScore() => ("r2d2", 1234, 15);

void DisplayScore2((string Name, int Points, int Level) score3)
{
    Console.WriteLine($"Name: {score3.Name} Level: {score3.Level} Score: {score3.Points}");
}

enum TileType { Grass, Water, Rock }
var tile = (Row: 2, Column: 4, Type: TileType.Grass);

var matrix = (M11: 1, M12: 0, M13: 0, M14: 0,
              M21: 1, M22: 0, M23: 0, M24: 0,
              M31: 1, M32: 0, M33: 0, M34: 0,
              M41: 1, M42: 0, M43: 0, M44: 0);

(string Name, int Points, int Level)[] CreateHighScores()
{
    return new (string, int, int)[3]
    {
        ("r2d2", 1234, 15),
        ("c-3po", 8453, 9),
        ("Gonk", -1, 1),
    };
}

var score4 = (Name: "me", Points: 1, Level: 3);
string playerName = score4.Name;

// deconstructing tuples 
string name3;
int points;
int level;
(name3, points, level) = score4;
Console.WriteLine( $"{name3} reached level {level} with {points} points");
// list each of the variables to store the deconstructed tuple in parentheses 
// (name3, points, level) copies each item in the tuple 'score' to their respective variables 

double x = 4;
double y = 5;
(x, y) = (y, x); // this swaps the contents of two variables 
//tuple deconstruction demands that the variables on the left match the tuple in count and types so if there is a var we don't need or want we can just throw it away using '_' with no type like this:
(string name3, int points, _) =  score4;

// _ is a discard variable 

// tuples and equality -- tuples are value types so we can check for equality 
// two tuple values are considered equal if they have the same number of items, the corresponding items are the same types, and if each item is equal to the corresponding item in the other tuple 
(int, int) u = (1, 2);
(int, int) v = (1, 2);
Console.WriteLine(u == v); // true 
Console.WriteLine(u != v); // false 


var uu = (X: 1, Y: 2);
var vv = (U: 1, V: 2);
Console.WriteLine(uu == vv); // true -- this shows that the names of the tuple elements do not matter bc they are different however the values matter bc they are the same 
Console.WriteLine(uu != vv); // false 



// CLASSES
/*objects -- a thing in your software, responsible for a slice of the entire program, containing data and methods, which define what info the oject must remember and the capabilities it can perform when requested 
 * 
 * c# objects are categorized into classes -- establishing vars and methods of any object belonging to the class (blueprint)
 * 
 * objects that fit into a class is known as an instance of that class 
 * 
 * 
 * 
 */


// instances of a class are created with the 'new' keyword. The 'Score()' thing refers to a special method called a constructor used to get new isntances ready for use 
Score best = new Score("me", 100, 3);
Score worst = new Score();
Score hardest = new Score("me", 100, 5, "legendary");
best.name = "r2d2";
best.points = 12340;
best.level = 14;


if (best.EarnedStar())
    Console.WriteLine("You earned a star");
class Score
{
    // these vars are not the same thing as local variables or parameters. They are fields or instance vars which are local to the method 
    // fields are variables created inside the object's memory on the heap 
    public string _name; 
    public int _points;
    public int _level;
    public string _difficulty;
    public string name;
    public int points;
    public int level;
    public string difficulty;

    //adding constructor  -- use naming convention _ prior in fields so that the parameters in the constructor can have the same name OR you can use the 'this' keyword which refers to the object you're calling from when the fields and parameters have the same exact name 
    public Score(string name, int points, int level)
    {
        _name = name; 
        _points = points;
        _level = level;
    }

    public Score(string name, int points, int level, string difficulty)
    {
        this.name = name;
        this.points = points;
        this.level = level;
        this.difficulty = difficulty;
    }

    public Score()
    {
        _name = "Unknown";
        _points = 0;
        _level = 1;
    }

    public bool EarnedStar() => (_points / _level) > 1000; // method which returns a bool and is public 
    // this method has access to its own local vars and parameters and also any vars defined in the class itself 

    // ENCAPSULATION -- bundle up data and the operations on that data into a well-defined cohesive unit (like a class) 
}

Score game1 = new Score();
game1.name = "game";
game1.points = 1231;
game1.level = 14;

Score game2 = new Score();
game2.name = "game2";
game2.points = 1232;
game2.level = 14;

if (game1.points > game2.points)
    Console.WriteLine($"{game1.name} scored more points by {game1.points - game2.points} points");
else
    Console.WriteLine("game2 scored more points");

//CONSTRUCTORS -- they are special methods that run when an object comes to life to ensure it begins life in a good state 
//     1. constructors must use the same name as the class, and they cannot list a return type 
//     2. constructors are allowed to have parameters, just like methods -- it lets the outside world provide the intial values for some fields 



class Score2
{
    public string _name;
    public int _points;
    public int _level;

    public Score2() : this("Unknown", 0, 1)
    {
    }

    public Score2(string name, int points, int level)
    {
        _name = name;
        _points = points;
        _level = level;
    }
}





// INFORMATION HIDING -- only the object itself should directly access its data 
//Rectangle rectangle1 = new Rectangle(4, 3);
////rectangle1._area = 200; // anyone can just change the value of the area so we need to handle public vs private 
//rectangle1.SetWidth(6);
//Console.WriteLine(rectangle1.GetArea()); // now the fields are private and we cannot use / see this  
//class Rectangle
//{
//    private float _width;
//    private float _height;
//    //private float _area;

//    public Rectangle(float width, float height)
//    {
//        _width = width;
//        _height = height;
//        //_area = width * height;
//    }

//    public float GetWidth() => _width;
//    public float GetHeight() => _height;
//    public float GetArea() => _width * _height;

//    public void SetWidth(float value) => _width = value;
//    public void SetHeight(float value) => _height = value;

//}


// ACCESSIBILITY MODIFIERS -- these change the access level of a thing they are applied to 
// public keyword gives the member public accessibility -- usable anywhere 
// private keyword gives the member private accessibility -- usable only within the class itself 
// instead of direct access to our fields we provide controlled access through methods 


/* WHEN TO USE PUBLIC VS PRIVATE 
 * 
 * a class should protect its data. fields almost always be private (rare exceptions exist) 
 * 
 * things should always be as inaccessible as possible while allowing the class to fulfill its role in the system
 * 
 * 
 */

/* ABSTRACTION -- the outside world does not need to know each object or class's inner workings and can deal with it as an abstract concept. 
 * Abstraction allows the inner workings to change without affecting the outside world 
 */

/* Diff between PUBLIC and INTERNAL
 * Public - can be accessed anywhere, including in other projects 
 * Internal - can only be used in the project it is defined in 
 */


/* PROPERTIES --pairs a getter and setter under a shared name with field-like access 
 * -- they are another member we can put in a class. They have their own accessibility level 
 * -- each property has a type 
 * 
 * GETTER (get) -- is required to return a value of the same type as the property 
 * SETTER (set) -- has access to the special value variable in its body
 * 
 * properties don't require both getters and setters. You can have a get-only or set-only property
 * 
 * get-only -- property makes sense for something that can't be changed from the outside 
 * 
 * get and set do not need the same level of accessibility. Get can be public and set can be private for example 
 */

Rectangle rectangle1 = new Rectangle(4, 3);
//rectangle1._area = 200; // anyone can just change the value of the area so we need to handle public vs private 
//rectangle1.Width = 6;
Console.WriteLine(rectangle1.Area); // now the fields are private and we cannot use / see this  
class Rectangle
{
    private float _width;
    private float _height;
    //private float _area;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
        //_area = width * height;
    }

    public float Width
    {
        get => _width;
        private set => _width = value;
    }

    public float Height
    {
        get => _height;
        set => _height = value;
    }
    public float Area => _width * _height;


    public void SetHeight(float value) => _height = value;

}



// AUTO-IMPLEMENTED PROPERTIES -- this public class Player can be written much more concisely -- seen on line 1018
public class Player
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value;
    }
}
// below -- defines properties of this nature via auto-implemented property or an auto property 
public class Player2
{
    public string Name { get; set; }
}


// immutable fields and properties 

/* auto-properties can be 'get-only' like a regular property (they cannot be set-only) 
 *when a property is get-only it can still be asigned values, but only from within a constructor (read-only properties) 
 */

public class Player3 // the getter is public so we can always retrieve Name current value and even w/o a setter we can assign a value to Name but we cannot change name after creation 
{
    public string Name { get; } = "Player 3";

    public Player3(string name)
    {
        Name = name;
    }
}


public class Player4 // when all of a class's properties and fields are immutable (get-only auto-properties and readonly fields) the entire object is immutable 
{
    private readonly string _name;

    public Player4(string name)
    {
        _name = name;
    }
}

// object initializer syntax and init properties 
public class Circle
{
    public float X { get; set; } = 0; // the x coord of circles center 
    public float Y { get; set; } = 0; // the y coord of the circles center 
    public float Radius { get; set; } = 0; 
}

Circle circle = new Circle();
circle.Radius = 3;
circle.X = -4; 
// object intializer syntax 
Circle circle2 = new Circle() { Radius = 3, X = 4 };
// we cannot use this type of syntax w/ get-only 



// init -- this is a setter that can be used in limited circumstances, including w/ an inline intializer (the 0's below) and in the constructor but also in the object initializer syntax
public class Circle2
{
    public float X { get; init; } = 0; // the x coord of circles center 
    public float Y { get; init; } = 0; // the y coord of the circles center 
    public float Radius { get; init; } = 0;
}

Circle2 circle3 = new Circle2 { X = 1, Y  = 2 };



// STATIC 
public class SomeClass
{
    private int _number;
    public int Number => _number;
}

// each instance of SomeClass has its own _number field, and calling methods or properties like the Number property is associated w/ specific instances and their individual date 
// each instance is independent of the others, other than sharing the same class def 
// but you can mark members of a class w/ 'static' keyword to detach them from individual instances and tie it to the class itself

// static field or var -- these are useful for defining vars that affect every instance in the class 
//public class Score3
//{
//    private static readonly int PointThreshold = 1000;
//    private static readonly int LevelThreshold2 = 4;

//    public bool IsWorthyOfHighScoreTable()
//    {
//        if (Point > PointThreshold) return false;
//        if (Level < LevelThreshold2) return false;
//                return true;
//    }

//    // if a field is static, public and NOT read-only, it creates global state 
//    // global state is data that can be changed and used anywhere in your program 
//}


// static properties 
/* they can use static fields as their backing fields or you can make them auto-properties
 * 
 */

// static methods -- it is not tied to a single instance, so it cannot refer to any non-static (instance) fields, properties, or methods
// they are most used for helper methods that provide some sort of service related to the class they are placed it but that is not tired directly to a single instance
//public static int CountForPlayer(string playerName, Score[] scores)
//{
//    int count = 0;
//    foreach (Score score in scores)
//        if (score.name == playerName) count ++ ;
//    return count;
//}


//public static Rectangle CreateSquare(float size) => new Rectangle(size, size);
//Rectangle rectangle = Rectangle.CreateSquare(2);


// NULL REFERENCES 
/*reference type vars like string, arrays and classes don't store their data directly in the variable. The var holds a reference and the data lives on the heap somewhere 
 * 
 * special reference: NULL REFERENCE -- helpful when it is possible for there to be no data available for something
 * 
 */
//string name44 = null;
//// NULL OR NOT? -- if null is allowed you will want to check it for null before using its members (methods, properties, fields, etc) 
//// any reference type var can either have a ? at the end or not. A ? means that it may legitimately contain a null value 
//string? name45 = Console.ReadLine(); // can return null or any legit string instance (without the ?, this means null is not an option) 
//if (name45 != null)
//    Console.WriteLine("the name is not null");

//// two ways to integrate null checks 
//private string? GetTopPlayerName()
//{
//    return _scoreManager?.GetScores()?[0]?.Name;
//}

//private string? GetTopPlayerName()
//{
//    if (_scoreManager == null) return null;

//    Score[]? scores = _scoreManager.GetScores();
//    if (scores == null) return null;

//    Score? topScore = scores[0];
//    if (topScore == null) return null;

//    return topScore.name;
//}

//// null coalescing operator : ?? -- takes an expression that might be null and provide a value or expression to use as a fallback if it is 
//private string GetTopPlayerName() // no longer needs null check 
//{
//    return _scoreManager?.GetScores()?[0]?.Name ?? "(Not found)"; // if the code before the ?? evaluates to null, then the fallback value of "(not found)" will be used instead 
//}


//private string GetTopPlayerName() // no longer needs null check 
//{
//    return _scoreManager?.GetScores()?[0]?.Name;
//    name ??="(Not found)";
//    return name;
//}

//// null-forgiving operator: ! (same as boolean not) this tells the compiler " i know this looks like a potential null problem, but it wont be, trust me" 
//string message = MightReturnNullIfNegative(+10)!;


//OBJECT-ORIENTED DESIGN 
/* possible first step - identify the concepts and jobs that the requirements reveal // concepts that apear in the requirements will often lead to classes of objects in design 
 * 
 * jobs / tasks in requirements will lead to responsibilities in the software
 * 
 * highlight the noun / verbs that appear in requirements
 * 
 * ex: asteroids drift through space at some specific velocity - nouns: asteroid, space, and velocity // verb: drift (one or many objects may take on this job) 
 * 
 * UML -- unified modeling language
 * 
 * CRC cards (class responsibility collaborator) -- are a way to think through potential object-oriented designs and flesh out details (1 card per object in the system). On each card
 * you will list three things 1. THE CLASS THAT THE OBJECT BLEONGS TO, WRITTEN AT THE TOP   2. THE RESPONSIBILITIES THAT OBJECT HAS ON THE LEFT SIDE  
 * 3. THE OBJECTS COLLABORATORS THAT HELP THE OBJECT FULFILL ITS RESPONSIBILITIES 
 * 
 *          class names should be nouns or noun phrases 
 *          responsibilities should be listed as a verb or verb phrase 
 *          collaborators of an object are the names of other classes that this object needs to fulfill its duties (helpers) 
 * 
 * evaluating design: 
 *          1. it has to work 
 *          2. prefer designs that convey meaning and intent 
 * 
 */



// INHERITANCE -- basing one class on another, retaining the original class's functionality while extending the new class with additional capabilities 
/* it allows you to treat the subtypes as the more generalized type whenever necessary. It also allows you to consilidate what you would otherwise duplicate or copy and paste in two closely related classes 
 * 
 * a relationship where a type can expand upon another is an inheritance relationship 
 * 
 * three things happpen when we define an inheritance relationship betwen two classes: 
 *          1. the new class gets everything the old class had 
 *          2. the new class can add in extra stuff
 *          3. the new class can always be treated as though it were the original since it has all of those capabilities 
 *          
 * The original is the base class (parent class or superclass). The new class that extends the base class is the derived calss (child class or subclass) 
 * 
 */






