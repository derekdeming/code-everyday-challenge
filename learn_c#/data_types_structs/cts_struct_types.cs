using System;

// structure type 
struct Point
{
    // structures can contain fields 
    public int xPos, yPos;

    // structures can contain parameterized constructors 
    public Point(int x , int y)
    {  xPos = x; yPos = y;}

    // structures may define methods 
    public void PrintPosition()
    {
        Console.WriteLine("({0}, {1}", xPos, yPos);
    }
}