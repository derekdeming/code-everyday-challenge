// CTS Delegate types 
// delegates are the .NET equiv of a type-safe, C-style function pointer. The key diff is that a .NET delegate is a class that derives from
// System.MulticastDelegate, rather than a simple pointer to a raw memory address

// this c# delegate type can "point to " any method returning an int and taking two ints as input 
delegate int BinaryOp(int x , int y)

//they are critical when you want to provide a way for one object to forward a call to another object and provide the foundation for the .NET event architecture 