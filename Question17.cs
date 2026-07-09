//17.Create variables to calculate electricity bills based on consumed units.
using System;
class Question17
{
    public void Dimensions()
    {
        double electricity= 15.5;
        double rate=6.50;
        double price;
        Console.WriteLine($"The consumed electricity is {electricity} in rate {rate}");
        price = electricity*rate;
        Console.WriteLine($"The total electricity bill:{price}");
    }
}