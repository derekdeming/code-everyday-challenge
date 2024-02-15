using System;

Console.WriteLine("**** c# app ****");
Console.WriteLine("**** Hello world");
Console.WriteLine();

// process any incoming args 
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Arg: {0}", args[i]);
}
Console.ReadLine();
// return arbitrary error code
return 0;