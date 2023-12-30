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

/* fields -- variable like, single access modifier, no separate getter and setter, cannot be overridden in derived classes, should always be private
 * properties -- method like, separate access modifiers for getter and setter, getter or setter may be removed, can be overridden in derived classes, can safely be public 
 * 
 * 
 */

using System.Drawing;
var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 20);
//var calculator = new ShapesMeasurementsCalculator();

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Width is " + rectangle1.GetHeight());
Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Width is " + rectangle2.GetHeight());

Console.WriteLine(rectangle1.Description);
Console.WriteLine(rectangle1.LongDescription);

var anotherCalculator = new Calculator();
Console.WriteLine($"1*2 is {anotherCalculator.Multiply(1,2)}");

// Static methods belong to a class as a whole, not to a specific instance. 
// static methods cannot use the instance data (values of fields or returned by properties)
// a static class cannot be instantiated; it only works as a container for methods 
// a static class can only contain static methods 
// non-static classes can contain static methods 
// if a private method doesn't use instance data, make it static 
// all const fields are implicitly static 
class Calculator  // stateless (has no state) 
{
    public static int Add(int a, int b) => a + b;

    public int Subtract( int a, int b ) => a - b;

    public int Multiply ( int a , int b ) => a * b;
}


//Console.WriteLine("Area is " + calculator.CalculateRectangleCircumference(rectangle1));
//Console.WriteLine("Circumference is " + calculator.CalculateRectangleArea(rectangle1));
class Rectangle // stateful ( has state - fields )
{
    //const fields are implicitly static
    public const int NumberOfSides = 4;

    public Rectangle (int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height)); 
    }

    //readonly property - can only be set in the constructor
    public int Width { get; }
    private int _height;

    public int GetHeight() => _height;
    
    // a readonly field can only be assigned at the declaration or in the constructor 

    public void SetHeight(int value)
    {
        if (value> 0)
        {
            _height = value;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        // const modifier can be applied to both variables and fields. Those variables and 
        // fields must be assigned at declaration and can never be modified afterward. 
        // They must be given a compile-time constant value 
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be positive number");
            return defaultValueIfNonPositive;
        }
        return length;
    }

    // using expression bodied method here bc both result in a return of a value -- can only use it when one expression or statement is present
    //could not be made static as they use the state of an instance (width and height)
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle._height;

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle._height;

    // a get-only, expression-bodied property 
    public string Description => $"A rectangle with width {Width} " + $"and height {_height}";

    public string LongDescription
    {
        get
        {
            var result = ""; 
            for (int i = 0; i < 100000; ++i)
            {
                result += i; 
            }
            return result;
        }
    }

    //a static method, not using any state of an instance
    public static string DescribeGenerally() =>
        $"A plane figure with four straight sides and four right angles.";



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



//var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
//var appointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");
//var appointmentUnknownPatient = new MedicalAppointment();
//var nameOnly = new MedicalAppointment("Name only");

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


/*Expression-bodied-methods -- used to make methods shorter by using => 
 * 
 * Statement -- something that does not evaluate to a value (e.g., Console.WriteLine("hi") or if(condition){}
 * Expression -- something that evaluates to a value -- 1 + 3 or GetText() 
 * 
 * 
 * 
 * 
 */

