//7.Store the length and breadth of a rectangle and calculate the perimeter.
using System;
class PerimeterOfRectangle7
{
    public void Perimeter()
    {
        int length =10;
        int breadth = 20;
        int p;
        Console.WriteLine($"The value of length and breadth is {length} and {breadth}");
        
        p=2*(length+breadth);
        Console.WriteLine($"The perimeter of rectangle is {p}");
    }
    
}
