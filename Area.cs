//Store the radius of a circle in a variable and calculate the area.
using System;
using System.Data;
using System.Net.NetworkInformation;
class Area
{
    public void AreaOfCircle()
    {
        const double Pi= 3.14;
        int Radius= 4;
        double Area= Pi * (Radius^2);
        Console.WriteLine($"The area of circle having radius {Radius} is {Area}");

    }
}