using System;

namespace EmployeeApplication

{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeId = 0;
            string firstName = string.Empty;
            string lastName = string.Empty;
            decimal annualSalary = 0;
            char gender = '\0';
            bool isManager = false;

            Console.WriteLine("Please enter a unique Id for this employee");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the employee's first name")
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the employee's last name");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter the employee's annual salary");
            annualSalary= Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the employee's gender ('f' = female, 'm' = male)");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The employee is a manager (true/false)");
            isManager = Convert.ToBoolean(Console.ReadLine());

            string genderTerm = (gender == 'f') ? "female" : "male";

            string managerNarrative = (isManager) ? "is part of the management team" : "currrent not part of the management team";

            string narrative = $"Employee with an Id of {employeeId}";
            narrative += $"who's full name is {firstName} {lastName}";
            narrative += $"is a {genderTerm} employee who is {managerNarrative}";

            Console.Clear();
            Console.WriteLine(narrative);
            Console.ReadLine();


        }
    }
}

// value type -- inherits from the 'ValueType' base class 
// inherit -- all types in C# ultimately inherit from the 'System.Object' class. Value types inherit from the 'ValueType' clas and the 'ValueType' class inherits from the 'System.Object' class
// a variable defined as a value type stores its value directly in memory. 

// reference types store a pointer to its data and not the data itself 
// the data itself is stored in a diff location in memory 
// the part of memory where value types are stored is known as a stack

// the stack is a fixed lenth location in memory allocated to each of the threads in an application 
// fixed length length value types are stored on top of each other on the stack while a sequence of instructions is excuted for a thread 
// these values are processed on a LIFO (last in first out) basis 

// a thread of execution is the smallest sequence of programmed instructions. Each of these threads can run in parallel asynchronously 

// class - group of related types, methods and events. It serves as a blueprint for an object. A class is a reference type. The new keyword is used to create an object from a class 

// reference types - inherit directly from the 'System.Object' class (which is itself a reference type). A variable defined as a reference type stores a 
// pointer or memory location to where the actual data resides. The memory location information is sotred as a numeric value on the stack and this value points to a portion of the memory 
// where the data resides in a memory location known as the heap 

// heap - is a location in memory that is not constrained by a fixed length. It is used for the storage of object data. Data is stored in a more haphazard way on the heap 
// when compared to the orderly way that data is stored on the stack. As a result memory management applied to the heap is more complex and therefore less efficient than memory management applied to the stack 
// unlike data stored on the stack, the data stored on the heap is not constrained by a fixed length. The size of the object data stored on the heap is only constrained by the physical resources of the cpu 
