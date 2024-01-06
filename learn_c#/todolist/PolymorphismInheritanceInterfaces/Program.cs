// Polymorphism -- the provision of a single interface to entities of different types 
/* in other words, there is a generic concept of something and this concept can be made 
 * concrete by multiple types. All of them can be used wherever the generic concept is needed 
 */


/* Inheritance -- enables us to create new classes that reuse, extend, and modify
 * the behavior defined in other classes 
 * 
 * the class whose members are inherited is called the base class, and the class that 
 * inherits those members is called derived class
 * 
 * inheritance is an "is-a" kind of relationship
 * 
 * ex structure: public class Cheddar : Ingredient
 * 
 * this is a public class named Cheddar which is inheriting the Ingredient class 
 * 
 * the base class -- contains data and methods common for any ingredient (or just basic implementation) 
 * the derived class -- is specific to the ingredient (cheddar in the ex) - specific implementation 
 * 
 * private methods cannot be inherited 
 * 
 * protected members can be used in the derived classes but they cannot be used outside 
 * 
 * virtual methods or properties may be overridden by the inheriting types (virtual and override keywords) 
 * 
 * 
 * Conversion -
 * 1. implicit conversion -- doesn't require cast expression. occurs when conversion is safe and lossless (example: integer to decimal)  
 * 2. explicit conversion -- requires cast expression (there is trimming of the data happening which is not safe) ex: decimal to int 
 *  explicit example: decimal c = 10.01m int d = (int)c; 
 *  
 *  Implicit conversion does not require any special syntax, unlike the explicit conversion, which requires writing the type name in parenthesis.
 *  
 *  
 */




// double variable = 10.01 - less precise but much faster than decimal
// decimal variable = 10.01m - very precise 

// "is" operator and null object - NumericTypesDescriber class coding exercise
public static class NumericTypesDescriber
{
    public static string Describe(object someObject)
    {
        if (someObject is int asInt)
        {
            return "Int of value " + asInt;
        }
        if (someObject is double asDouble)
        {
            return "Double of value " + asDouble;
        }
        if (someObject is decimal asDecimal)
        {
            return "Decimal of value " + asDecimal;
        }
        return null;
    }
}

/* 'as' operator -- will give null if cast fails so it only works to cast to nullable types. 
 * cannot cast to int types because they cannot be null 
 * 
 * 
 */

//////public static class NumericTypesDescriber
//////{
//////    public static string Describe(object someObject)
//////    {
//////        if (someObject is int asInt)
//////        {
//////            return "Int of value " + asInt;
//////        }
//////        if (someObject is double asDouble)
//////        {
//////            return "Double of value " + asDouble;
//////        }
//////        if (someObject is decimal asDecimal)
//////        {
//////            return "Decimal of value " + asDecimal;
//////        }
//////        return null;
//////    }
//////}

public static class AbstractMethodsShapesExercise
{
    public static List<double> GetShapesAreas(List<Shape> shapes)
    {
        var result = new List<double>();

        foreach (var shape in shapes)
        {
            result.Add(shape.CalculateArea());
        }

        return result;
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Square : Shape
{
    public double Side { get; }

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea() => Side * Side;
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Width * Height;
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;
}

//Extension methods - List extensions
public static class ListExtensions
{
    public static List<int> TakeEverySecond(this List<int> list)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < list.Count; i += 2)
        {
            result.Add(list[i]);
        }
        return result;
    }
}

//Interfaces - Applying multiple transformations to a number
public static class InterfacesApplyingMutipleTransformationsToNumberExercise
{
    public static int Transform(
        int number)
    {
        var transformations = new List<INumericTransformation>
            {
                new By1Incrementer(),
                new By2Multiplier(),
                new ToPowerOf2Raiser()
            };

        var result = number;
        foreach (var transformation in transformations)
        {
            result = transformation.Transform(result);
        }
        return result;
    }
}

public interface INumericTransformation
{
    int Transform(int number);
}

public class By1Incrementer : INumericTransformation
{
    public int Transform(int number) => ++number;
}

public class By2Multiplier : INumericTransformation
{
    public int Transform(int number) => number * 2;
}

public class ToPowerOf2Raiser : INumericTransformation
{
    public int Transform(int number) => number * number;
}
enum Season { Winter, Spring, Summer, Fall }
Season current = Season.Summer;

if (current == Season.Summer || current == Season.Winter)
    Console.WriteLine("Happy Solstice") ;
else
    Console.WriteLine("Happy equinox");