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

/*
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
*/


/* ABSTRACTION - means that classes expose only essential data and methods and hide the underlying details 
 * 
 */

// a FIELD is a variable that belongs to an object of a class
// if we don't intialize a field, it is automatically set to the default value for its type


/* DATA HIDING: 
 * 1. data hiding means making the members of a class non-public 
 * 2. class members are anything that a class contains, especially fields and methods 
 * 3. we should only make a member public if necessary 
 * 4. making class members public can be a source of risk 
 * 5. to control who can access components of a class, we use the access modifiers 
 * 6. private members can only be accessed from within the class it belongs to 
 * 7. public members can be accessed everywhere 
 * 8. private variables are named like so: _width or _height
 * 9. public vars are n amed like so: Width or Height (Capitalized first letter) 
 */

using System.Drawing;

var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 20);
var calculator = new ShapesMeasurementsCalculator();

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Width is " + rectangle1.Height);
Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Width is " + rectangle2.Height);

Console.WriteLine("Area is " + calculator.CalculateRectangleCircumference(rectangle1));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleArea(rectangle1));
class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle (int width, int height)
    {
        Width = width;
        Height = height; 
    }
}

class ShapesMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}


// virtually all C# code must belong to some class 
// name of a method should always start with a verb 


/* ENCAPSULATION -- bundling data with methods that operate on this data (in single class) 
 * 
 * Differences between ENCAPSULATION VS DATA HIDING: 
 * 1. Encap: bundling data with methods that operate on it in the same class 
 * 2. Data Hiding: making fields private instead of public 
 * 
 */

//Console.WriteLine("Height is " + rectangle1.GetHeight());
//Console.WriteLine("Area is " + rectangle1.CalculateArea());
//Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());