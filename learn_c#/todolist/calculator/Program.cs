Console.WriteLine("Hello");

Console.WriteLine("Input the first number: ");
var userNumberOne = Console.ReadLine();
int userNumber1 = int.Parse(userNumberOne);

Console.WriteLine("Input the second number: ");
var userNumberTwo = Console.ReadLine();
int userNumber2 = int.Parse(userNumberTwo);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var userInput = Console.ReadLine();



if (userInput == "A" || userInput == "a")
{
    int addition = userNumber1 + userNumber2;
    PrintFinalEquation(userNumber1, userNumber2, addition, "+");

}
else if (userInput == "S" || userInput == "s")
{
    int subtract = userNumber1 - userNumber2;
    PrintFinalEquation(userNumber1, userNumber2, subtract, "-");


}
else if (userInput == "M" || userInput == "m")
{
    int multiply = userNumber1 * userNumber2;
    PrintFinalEquation(userNumber1, userNumber2, multiply, "*");


}
else
{
    Console.WriteLine("Wrong Entry, now exiting program");
}


void PrintFinalEquation(
    int userNumber1, int userNumber2, int result, string @operator)
{
    Console.WriteLine(userNumber1 + " " + @operator + " " + userNumber2+ " = " + result);
}

bool EquationCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

