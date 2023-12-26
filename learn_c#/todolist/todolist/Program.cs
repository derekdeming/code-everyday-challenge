Console.WriteLine("Hello");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

string userInput = "A"; // explicitly typed variables 
Console.WriteLine(userInput);

userInput = "ABC"; 
Console.WriteLine(userInput);

int numberVar; // this is declaration of variable 
numberVar = 3; // this is intialization of it 

string text = "Hello"; // this is intialization and declaration 

int a = 1, b = 4;
++a; //this increment by 1 
--b;//this decreases by 1 
string name, lastname;

Console.WriteLine(a + b);
name = "derek";
lastname = "bob";
Console.WriteLine(name + " " + lastname);

// Naming variable rules:
// 1. C# keywords cannot be used as variable names 
// 2. Names can contain letters, digits, and the underscore (_) char, but the first char cannot be a digit 
// 3. C# is case-sensitive; the names count and Count are two diff vars 

Console.WriteLine("Addition: " + (a + b)); 
Console.WriteLine("Subtraction: " + (a - b)); 
Console.WriteLine("Multiplication: " + a * b); 
Console.WriteLine("Division: " + a / b);

// implicitly typed variables -- need to be declared & initialized at the same time 
var word = "abc";
var number1 = 1;
Console.WriteLine(word);
Console.WriteLine(number1);

Console.ReadKey();

// addition (+) operator can be used with string and int but subtraction operator (-) cannot compile 
// multiplication and division have higher precedence than addition and subtraction 
