//10.Store the temperature in Celsius and convert it to Fahrenheit.
using System;
class Conversion10
{
    public void Convert()
    {
        double celsius=36.5;
        double Fahrenheit;
        Console.WriteLine($"The celsius reading of the tempr is {celsius}");
        Fahrenheit=(celsius * 9 / 5) + 32;
        Console.WriteLine($"The fahrenheit scale is {Fahrenheit}");
    }
}