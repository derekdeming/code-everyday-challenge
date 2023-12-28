// OBJECT-ORIENTED PROGRAMMING (OOP) 

/* objects - containers for data and methods 
 * classes - a blueprint for objects of the same type 
 *         - contain objects (instances) of the classes 
 * OOP heavily relies on the following: 
 *      1. encapsulation 
 *      2. polymorphism 
 *      3. abstraction 
 *      4. inheritance 
 */


var internationalPizzaDay23 = new DateTime(2023, 2, 9);
// DateTime(year, month, day, hour, minute, second) 
Console.WriteLine("year is " + internationalPizzaDay23.Year);
Console.WriteLine("month is " + internationalPizzaDay23.Month);
Console.WriteLine("day is " + internationalPizzaDay23.Day);
Console.WriteLine("day of the week is " + internationalPizzaDay23.DayOfWeek);
Console.WriteLine("day of the year is " + internationalPizzaDay23.DayOfYear);

var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);
Console.WriteLine("");

Console.WriteLine("year is " + internationalPizzaDay24.Year);
Console.WriteLine("month is " + internationalPizzaDay24.Month);
Console.WriteLine("day is " + internationalPizzaDay24.Day);
Console.WriteLine("day of the week is " + internationalPizzaDay24.DayOfWeek);
Console.WriteLine("day of the year is " + internationalPizzaDay24.DayOfYear);


/* ABSTRACTION - means that classes expose only essential data and methods and hide the underlying details 
 * 
 */
