//16.Store the dimensions of a room and calculate its volume.
using System;
class Question16
{
    public void Dimensions()
    {
        double length=5;
        double breadth=8;
        double height=9;
        double volume;
        Console.WriteLine($"The value of Length, breadth and height in feet is {length},{breadth} and {height}");
        volume = length* breadth*height;
        Console.WriteLine($"The volume of the room is {volume}");
    }
}