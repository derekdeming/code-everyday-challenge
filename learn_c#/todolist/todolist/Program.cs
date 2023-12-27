Console.WriteLine("Hello!");

//while (!shallExit) = false;
//{
Console.WriteLine();
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

switch (userChoice)
{
    case "E":
    case "e":
        PrintSelectedOption("Exiting program");
        break;
    case "S":
    case "s":
        PrintSelectedOption("See all todos");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a todo");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a todo");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
//}

//if (userChoice == "S")
//    {
//        PrintSelectedOption("See all todos");
//    }
//else if (userChoice == "A")
//    {
//        PrintSelectedOption("Add a todo");
//    }
//else if (userChoice == "R")
//    {
//        PrintSelectedOption("Remove a todo");
//    }
//else
//    {
//        PrintSelectedOption("Exited program");
//    }


void PrintSelectedOption(string option)
{
    Console.WriteLine("Selected option: " + $"{option}");
}