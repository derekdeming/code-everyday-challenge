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