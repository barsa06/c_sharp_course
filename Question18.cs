//18.Store distances of three routes and determine the total travel distance.
using System;
class Question18
{
    public void Distance()
    {
    double distance1 = 50.3;
    double distance2 = 40;
    double distance3 = 70;
    double total;
    Console.WriteLine($"The distance of 3 routes are {distance1},{distance2}and {distance3}");
    total = distance1+ distance2+ distance3;
    Console.WriteLine($"The total distance is {total}");
    }
}