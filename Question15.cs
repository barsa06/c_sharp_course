//15.Create variables for hours, minutes, and seconds, then convert everything into total seconds.
using System;
class Question15
{
         public void Conversion()
    {
        int hours=5;
        int minutes = 3;
        int seconds = 57;
        int total;
        Console.WriteLine($"Hours:{hours}");
        Console.WriteLine($"minutes:{minutes}");
        Console.WriteLine($"seconds:{seconds}");
        total = (hours*3600)+(minutes*60)+seconds;
        Console.WriteLine($"The total time in seconds is {total}");

    }
}