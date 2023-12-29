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
    // using expression bodied method here bc both result in a return of a value -- can only use it when one expression or statement is present
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}


// virtually all C# code must belong to some class 
// name of a method should always start with a verb 


/* ENCAPSULATION -- bundling data with methods that operate on this data (in single class) 
 * 
 * Differences between ENCAPSULATION VS DATA HIDING: 
 * 1. Encap: bundling data with methods that operate on it in the same class 
 * 2. Data Hiding: making fields private instead of public 
 *
 *
 * We cannot have two methods with the same names and parameters, but a different return type, in a single class.

 */

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("appointment will take place on " + medicalAppointment.GetDate());
    }
}


class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    //public MedicalAppointment(string patientName) : 
    //    this(patientName, 7) // calling another constructor (below) -- compiler knows based on parameters and names 
    //{
    //}    
    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public DateTime GetDate() => _date;

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void OverwriteMonthAndDay(int month, int day) // using method overloading (this is okay as long as you can tell one method from another based on type, order or count of parameters, naming the method the same is fine 
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year, 
            _date.Month + monthToAdd, 
            _date.Day + daysToAdd);
    }
}


/*Expression-bodied-methods -- used to make methods shorter
 * 
 * Statement -- something that does not evaluate to a value (e.g., Console.WriteLine("hi") or if(condition){}
 * Expression -- something that evaluates to a value -- 1 + 3 or GetText() 
 * 
 * 
 * 
 * 
 */