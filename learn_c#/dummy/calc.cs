using System;

Calc c = new Calc();
int ans = c.Add(10, 84);
Console.WriteLine("10 + 84 is {0}.", ans);
Console.Readline();

class Calc
{
    public int Add(int addend1, int addend2)
    { return addend1 + addend2; }
}